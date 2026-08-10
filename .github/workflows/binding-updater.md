---
emoji: 🔄
name: Binding Updater
description: Keeps a binding current with its upstream specification, fixing the generator when a new construct breaks it.
labels: [bindings, maintenance, scheduled]
on:
  schedule:
    - cron: "0 2 1 * *"
  workflow_dispatch:
  issues:
    types: [labeled]
permissions:
  contents: read
  issues: read
  pull-requests: read
  copilot-requests: write
strict: true
model: claude-sonnet-5
max-turns: 60
timeout-minutes: 40
max-ai-credits: 600
network:
  allowed:
    - defaults
    - github
env:
  # The dotnet CLI phones home to dc.services.visualstudio.com, which the firewall
  # blocks and then reports as a failed request the agent has to reason about.
  # Opting out is cleaner than widening the allow-list for telemetry.
  DOTNET_CLI_TELEMETRY_OPTOUT: "1"
  DOTNET_NOLOGO: "1"
steps:
  # The agent has to run the generator and build the binding, so the SDK must be
  # present before it starts. Without this the agent reaches the build, finds no
  # `dotnet`, and reports a broken generator that is not broken.
  # Every binding in the fleet currently targets net10.0; a repository on a
  # different framework overrides this by editing its installed copy, which
  # `gh aw update` preserves through its three-way merge.
  - name: Set up .NET
    uses: actions/setup-dotnet@v5
    with:
      dotnet-version: "10.x"
  # Fetching the specification and deciding whether it moved is a byte comparison,
  # not a judgement call. The first pilot run spent 29 bash turns doing it by hand
  # and the audit flagged 93% of its turns as data-gathering. Doing it here costs
  # nothing and leaves the agent to start where the thinking actually begins.
  - name: Fetch upstream sources
    id: upstream
    uses: EvergineTeam/Evergine.Bindings/.github/actions/binding-fetch-upstream@v1
tools:
  github:
    mode: gh-proxy
    toolsets: [default]
  bash: [":*"]
  edit:
safe-outputs:
  create-pull-request:
    title-prefix: "chore(binding): "
    labels: [agent:binding-update]
    allowed-labels: [agent:binding-update, needs-human-review]
    draft: false
    if-no-changes: "ignore"
  create-issue:
    title-prefix: "Binding update: "
    labels: [agent:needs-human]
    allowed-labels: [agent:needs-human, agent:upstream-break]
    deduplicate-by-title: true
    max: 1
source: EvergineTeam/Evergine.Bindings@ace4e8d477b877e973e5c748a81aff8f24c6fe42
---

# Binding Updater

Keep this binding in step with the specification it is generated from.

You run in one of two situations, and they differ only in urgency:

- **On schedule or on demand** — routine. Most months upstream has not moved and you will finish in seconds having spent nothing.
- **Because an issue was labelled `agent:needs-regen`** — the CI doctor found something it cannot fix and handed it to you. Read that issue first: it contains the failing construct and the compiler error, and it is the whole reason you were woken.

If you were triggered by a label that is not `agent:needs-regen`, call `noop` immediately and stop.

## Step 1 — read the manifest

`binding.yml` at the repository root is your only source of truth for where things live. It tells you the upstream sources and how to fetch them, which paths are generated output, where the generator project is, and what the package publishes.

Do not infer paths from the directory layout. Do not hardcode a URL you saw in a workflow file. If `binding.yml` is missing or does not validate, stop and open an issue saying so — everything below depends on it.

**If the manifest has no `generator` block, call `noop` and stop immediately.** Say nothing, open nothing. You regenerate a binding from a specification, and a repository with no generator has nothing for you to run — it is a hand-maintained C wrapper, and `cpp-wrapper-porter` looks after it. Agents install as a package, so you arrive everywhere the toolbox is consumed, and reporting on a repository you cannot act on produces one piece of noise per repository per month.

Manifests carry a `NOTE` comment where the repository has a hazard: a pinned ref that must not move, native binaries that must be rebuilt alongside a header, an upstream we maintain ourselves. **Read those notes and obey them.** They exist because someone already thought about this repository and reached a conclusion you are not being asked to revisit.

## Step 2 — read the upstream report

**The fetching is already done.** A deterministic step ran before you, pulled every source declared in the manifest using the right adapter, wrote the new content into the working tree, and left a report at `/tmp/gh-aw/agent/upstream-report.md`.

Read that file. It is one screen long and it tells you which sources moved.

**If it says nothing changed: call `noop` and stop immediately.** Do not re-download anything to check. Do not open the registry to look for yourself. The comparison was a byte-for-byte hash and it is not improved by a second opinion. This is the expected outcome most months and it is what keeps this workflow nearly free to run.

If the report is missing, the step failed — say so and stop, rather than fetching by hand.

**For `git-submodule` repositories the report only tells you the pointer is behind; nothing has been checked out.** That is deliberate. Bumping a submodule in KTX.NET means rebuilding native binaries, and in ImGui.Net it means moving four interdependent modules as a compatible set. Report the gap and stop unless the manifest explicitly says otherwise.

**For `kind: vendored` the "nothing changed" rule above does not decide your answer, and what woke you does.** Nothing fetches these upstreams because nothing can: the sources are behind a sign-in and a licence acceptance, so they arrive by hand and are already in the tree before you start. The report will say so on every run.

- **Woken on schedule or on demand**: `noop` and stop. You cannot chase a bump you cannot download, and a newer upstream is reported by a separate watcher that opens an issue for a human.
- **Woken by `agent:needs-regen`**: this is your case. Somebody refreshed the sources, the regeneration that followed failed, and the CI doctor handed it to you. Everything you need is in the working tree. Read the failure, fix the **generator** so it produces correct output from the sources as they now stand, and open a pull request.

Do not propose a URL, a script or an adapter that downloads the upstream. That download is gated on a person accepting a licence, and routing around it is not an improvement.

## Step 3 — regenerate and build

The new sources are already on disk. Run the generator, build the binding.

**If it builds**, open a pull request. Describe the API delta in terms a reader can act on — extensions, enums, structures and commands added, removed or changed, and the upstream version if the manifest says how to determine it. Not a diff dump: the point is to let a reviewer see whether anything alarming happened.

**If it fails to build**, the generator does not understand something new in the specification. This is the interesting case and the reason this workflow uses a strong model.

Diagnose it. Fix the generator so it handles the new construct properly — not so it skips it, not so it special-cases the one symbol that broke, unless narrowness is genuinely correct. Then regenerate and build again.

When you have touched anything under the generator project, label the pull request **`needs-human-review`**. Generator changes affect every symbol produced from that point on, and a subtle mistake surfaces as a runtime crash in someone's renderer months later, not as a red build. That label is not a formality.

## Step 4 — when you cannot finish

Open an issue with `agent:needs-human` and stop, if:

- The upstream change is not absorbable by regenerating — label it `agent:upstream-break` as well.
- The fix belongs upstream rather than here. Several manifests point at wrappers we maintain ourselves (`CesiumC`, `JoltPhysicsC`); when the C layer is missing something, the right change is a pull request there, not a workaround in the generator. Say so instead of papering over it.
- The manifest's notes forbid what would otherwise be the fix — a frozen ref, a submodule bump requiring a native rebuild, several interdependent submodules that must move as a compatible set.
- You are not confident. A wrong regeneration compiles cleanly and corrupts memory at runtime. Stopping is cheap; that is not.

State clearly what you tried and where you stopped. Leaving the issue's `agent:needs-regen` label in place is correct — the work is not done.

## Rules

- **Never touch the default branch.** Everything goes through a pull request.
- **Never bump a pinned ref on your own initiative.** Where the manifest pins a tag it is because header and shipped binary must match; moving it without rebuilding the native side produces a managed layer that does not match the binary it loads. You may *report* that a newer upstream release exists.
- **Do not re-label the issue that woke you.** That is how loops start.
- **Generated output is yours; hand-written code is not.** The manifest's `generator.output` lists exactly which paths you may rewrite. Files outside those paths — even inside the same project directory — are hand-written and must be left alone.
- **One pull request per concern.** A specification update and a generator fix that enables it belong together. A specification update and an unrelated refactor do not.

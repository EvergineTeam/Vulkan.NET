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
model: claude-opus-4.6
max-turns: 60
max-ai-credits: 600
network:
  allowed:
    - defaults
    - github
steps:
  # The agent has to run the generator and build the binding, so the SDK must be
  # present before it starts. Without this the agent reaches step 3, finds no
  # `dotnet`, and reports a broken generator that is not broken.
  # Every binding in the fleet currently targets net10.0; a repository on a
  # different framework overrides this by editing its installed copy, which
  # `gh aw update` preserves through its three-way merge.
  - name: Set up .NET
    uses: actions/setup-dotnet@v5
    with:
      dotnet-version: "10.x"
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
source: EvergineTeam/Evergine.Bindings@b0fc3aa02335a99b944ef89891758e21246e1c11
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

Manifests carry a `NOTE` comment where the repository has a hazard: a pinned ref that must not move, native binaries that must be rebuilt alongside a header, an upstream we maintain ourselves. **Read those notes and obey them.** They exist because someone already thought about this repository and reached a conclusion you are not being asked to revisit.

## Step 2 — check whether anything changed, cheaply

Fetch each source using the adapter named by `upstream.kind` and compare with the vendored copy.

**Do this with a file comparison, not with reasoning.** Never read a multi-megabyte registry into your context to decide whether it changed — `vk.xml` alone is several megabytes and there is no judgement involved in a byte comparison.

If nothing changed: **call `noop` and stop.** This is the expected outcome most months, and it is what makes running an expensive model here affordable. Do not look for something to do.

## Step 3 — regenerate and build

Write the new sources to the paths given in the manifest, run the generator, build the binding.

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

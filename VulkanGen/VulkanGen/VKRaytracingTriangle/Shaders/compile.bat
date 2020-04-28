start "" /d "%cd%" "%cd%/../third_party/glslang/glslangValidatorWindows" -V ray-generation.rgen   -o ray-generation.spv
start "" /d "%cd%" "%cd%/../third_party/glslang/glslangValidatorWindows" -V ray-closest-hit.rchit -o ray-closest-hit.spv
start "" /d "%cd%" "%cd%/../third_party/glslang/glslangValidatorWindows" -V ray-miss.rmiss        -o ray-miss.spv

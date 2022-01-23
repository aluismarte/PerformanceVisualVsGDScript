# Performance Visual script vs GDScript on Godot

Some elements are write on C# to skip this on performance test (FPS Counter and FlashLight)

# Benchmark

- No Debug
- 60 Seconds without move camera

## Tested on:

- Intel Core I7 11370H 3.3 Ghz
- 16 GB Ram DDR4 3200
- NVidia Geforce RTX 3060 Laptop GPU

## Results

| Language      | Max FPS | Stable FPS |
|---------------|:-------:|:----------:|
| Visual Script |   888   |  826.5957  |
| GDScript      |   860   |  828.6711  |


This folder contains generated placeholder pixel assets and instructions.

Files included here:
- alpinator_placeholder.png.base64  — 1x1 transparent PNG encoded in base64 (decode to get a valid PNG). Replace with a real 32x48 pixel sprite.
- flask_placeholder.png.base64      — 1x1 transparent PNG encoded in base64 (decode to get a valid PNG). Replace with a real bottle sprite.
- chiptune_melody.txt               — a short tracker-style melody you can load into Famitracker / MilkyTracker as a starting point.

How to convert base64 -> PNG (Linux/macOS):
  base64 -d alpinator_placeholder.png.base64 > alpinator_placeholder.png

Windows (PowerShell):
  [System.IO.File]::WriteAllBytes('alpinator_placeholder.png',[System.Convert]::FromBase64String((Get-Content alpinator_placeholder.png.base64)))

After decoding, move the PNG into Assets/Art/... and set import settings: Filter Mode = Point, Compression = None, Pixels Per Unit = 32.

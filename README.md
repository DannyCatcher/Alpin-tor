# Alpinátor - Prototype

This branch contains the Unity project skeleton and core gameplay scripts for the "Alpinátor" mobile prototype.

What is included in this branch (prototype skeleton)
- Assets/Scripts/ - core C# scripts (GameManager, Spawner, Flask, PlayerController, CameraSway, UIManager)
- README.md (this file)
- LICENSE (MIT)
- .gitignore (Unity)
- build/alpinator_placeholder.apk (placeholder APK file — replace with a real build)
- Assets/Art/ - placeholder instruction files (place your pixel art PNGs here)
- Assets/Scenes/MainScene-README.txt - instructions to create the MainScene in Unity (scene file not included)

Notes
- I couldn't create a full Unity project with binary Scenes/ProjectSettings in this environment. The scripts and README give you everything needed to create the Unity project locally and drop scripts and assets in place.
- The placeholder APK file is just a small text placeholder named with .apk extension. Replace it with a real build if you want an actual APK in the repository.

How to use
1. Open Unity Hub and create a new 2D project using Unity 2022.3 LTS (recommended).
2. Copy the Assets/ folder from this branch into your project (or copy the scripts from Assets/Scripts into your project's Assets/Scripts folder).
3. Create a MainScene in the Scenes folder and follow the instructions in Assets/Scenes/MainScene-README.txt to wire up GameObjects and UI.
4. Import your pixel-art PNGs into Assets/Art and set their import settings: Filter Mode = Point, Compression = None, Pixels Per Unit = 32.
5. Open the scene and run. Build for Android/iOS as needed.

If you'd like, I can now:
- Add a GitHub Actions workflow to auto-build an APK in CI (requires Unity license secrets).
- Replace the placeholder APK by committing a real build if you upload one here.

Enjoy — tell me if you want me to add CI or a real scene file and I will continue.

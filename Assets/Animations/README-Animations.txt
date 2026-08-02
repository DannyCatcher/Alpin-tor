Animation creation notes

To make AnimationClips from the frames in Unity:
1. Select the folder with the decoded PNG frames (e.g., Assets/Art/Characters/anim).
2. In the Sprite Editor, set each PNG's Sprite Mode = Single and PPU = 32.
3. To create a clip: select the frames in order and drag them into the scene or the Animator window. Unity will ask to save an AnimationClip (e.g., Assets/Animations/Idle.anim).
4. Set Sample rate (e.g., 12-14 fps) to get the desired animation speed.
5. Create other clips for Walk, Catch, Dizzy the same way.

I can generate sample .anim YAML clips and an AnimatorController file directly if you want — but Unity sometimes requires reassigning in-editor; let me know if you want me to push serialized .anim files too.

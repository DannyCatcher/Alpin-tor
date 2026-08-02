MainScene is not included (binary Unity scene files are not created here). Follow these steps inside Unity to create MainScene:

1. Create a new Scene and save it as Assets/Scenes/MainScene.unity
2. Camera:
   - Set Projection: Orthographic
   - Add CameraSway component (from Assets/Scripts)
   - Attach Pixel Perfect Camera if you use the package
3. Create empty GameObject 'GameManager' and add the GameManager script. Assign UI Text references after creating UI.
4. Player:
   - Create sprite for Alpinátor, add Rigidbody2D (Kinematic), BoxCollider2D, child 'Catcher' with trigger Collider and tag 'PlayerCatcher'.
   - Add PlayerController component.
5. Spawner:
   - Create empty GameObject 'Spawner' and add Spawner script, assign Flask prefab.
6. Flask prefab:
   - Create GameObject with SpriteRenderer (flask), Rigidbody2D (Dynamic, GravityScale 0), BoxCollider2D (IsTrigger true) and Flask script.
7. MissZone:
   - Create an empty GameObject at Y below the bottom of camera, add BoxCollider2D set IsTrigger true and tag 'MissZone'.
8. UI:
   - Create Canvas (Screen Space - Camera). Add Text elements for caughtText and missedText. Create GameOverPanel and leaderboards as described in README.

After wiring references, save scene and press Play.

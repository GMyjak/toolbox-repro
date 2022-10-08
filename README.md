## Steps:
1. Delete `Library/ArtifactDB` if exists
2. Open project
3. Start play mode with SampleScene
4. On first launch console will throw exception 

`Cannot load scene: Invalid scene name (empty string) and invalid build index -1`

5. On second launch project will behave as intended (open second scene)

This happens because indexes returned by cache in `SerializedScene.cs` are -1. 

This is not a huge issue during development because indexes will be updated on second launch of the app and it will behave correctly. But if app is built using some sort of CI pipeline and cache is cleared between builds, app will be built with serialized indexes with value -1 and this will cause serious runtime issues.

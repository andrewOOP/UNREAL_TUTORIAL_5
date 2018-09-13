# UNREAL_TUTORIAL_5
User Interface With UMG https://docs.unrealengine.com/en-us/Programming/Tutorials/UMG

## What I Learned
How to make and change UI screens, which is very different from how Unity handles it. I think I like it better than Unity because each screen has it's own file containing all the UI elements, unlike Unity where it has to be in a scene canvas that you have to zoom out and set the screen to 2D to see.

## Notes
* GameMode.h is now GameModeBase.h

* There’s so many functions that are just callable from anywhere.. FInputModeGameAndUI() is one of them. Since it’s not a dot function, Visual Studio won’t recommend them, so… guess I gotta memorize them.

* So it seems like GameMode holds all of the UI, and the blueprint widget holds all of the actual UI elements and functionality. It’s pretty tedious to change the gamemode, though… Guess it’s something I’ll just have to deal with

* Seems UI is both more and less tedious than Unity. Changing UI is more tedious, but creating UI is much better in Unreal because you have it’s own containing file instead of a canvas

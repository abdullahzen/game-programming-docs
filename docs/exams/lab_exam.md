# Lab Exam: Mini Golf (100 points = 15% weight)

## Duration: 2 hours

# Task 0: Preparation
1. Extract project
1. Load project into Unity Hub
1. Open project and load the corresponding scenes from the folder `LabExam/Assets/Scenes/`
> The given project already contains all the models, assets, and sound files that you need. The models have already been aligned properly in the scene with respct to each other and to the camera.

> Some scripts and components already exist.

> Important note about mesh colliders: in some cases in this project, the mesh collider works WITHOUT convex. Make sure to test it without convex before setting it to true as you may not need it.

# Task 1: Animation
Create a new animation on the golf clube:
* The golf clube should swing back when the space bar is pressed.
* While the space bar is held down, the force that will be used to hit the ball should keep incrementing at a small amount.
* Once the space bar is released, the gold clube should swing forward and hit the ball (apply force on the ball).

# Task 2: Complete the specifications & Bug fixes
* Golf ball should rest, and roll on the floor without falling through it.
* Movement of the golf ball is not realistic, and the force seem to make it fly sometimes. This needs to be improved.
  > Hint: friction, or limits on the force.
* The golf ball currently goes through the windmill and its rotating blades. Ensure that the blades and the windmill body are solid and that the ball doesn't go through them.

# Task 3: UI
* Fix the existing buttons in the main menu:
  * Start: should start the game
  * Exit: should exit the application
* The game needs to have a pause functionality when pressing on the `esc` key on the keyboard, and a new menu should show up with two options:
  * Resume: resumes the game
  * Change Name: text field to change the player name displayed in the scene (look for the playername label in the main scene)
  * Reset Game: restarts the game and brings back to the main menu.


# Task 4: Sounds
* Add the following sounds to the mini golf game:
  * An ambience (background) music playing at a **low** volume all the time.
  * Swinging sound when the golf club is swinging forward.
  * A hit sound when the golf club hits the golf ball.
  * A rolling ball sound while the golf ball is rolling on the floor.

# Submission
* Save everything and close Unity
* Delete ONLY the `Library` folder from the project folder
* Zip everything and submit the zip file on Lea in the exam submission box

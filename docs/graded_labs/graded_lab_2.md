# Graded Lab 2 (5% weight)

## Prerequisites
* Extract the project sent to you via Mio into your own Github labs repository. (The one you used last time for submitting graded-lab-1).

>Hint: Before trying to implement something new, make sure you check the existing code and scripts.

# Task 1: Bugs Fixing
0. Play the game
1. The animation plays when the space bar is clicked and released. However, on release, the stick is not hitting the ball.
1. Balls are going through the pockets and their walls. (Currently, there are no walls behind the holes)
1. Balls are moving very fast on the table. (the table or balls seem to have little to no resistance)
    - Do **NOT** change the max force/speed set in the script. You need to modify different resistance force properties until it looks realistic. (Hint: Dynamic friction, Drag, Angular Drag, Bounciness)

# Task 2: Simple Scoring System
Implement a simple scoring system with the following specifications:
* When the 8 ball enters a pocket, a Debug message is printed indicating "Game Over" and then a restart of the game is triggered.
* When the white ball enters a pocket, only the white ball's position is reset to its starting position.
* When any colored/striped ball enters a pocket, a score is incremented by 1. (No distinction needs to be made between striped/solid balls).

# Task 3: Nice to have features
* Balls can fly off the table sometimes. (Hint: we want to do something so none of the balls could fly off the table or lift a bit off the table). 
* Move the pool stick relative to the white ball after every round without compromising the animation's positions. (Hint: some manipulations of animation and/or manipulation of gameobject hierarchies could be required).

# Submission
Submit the whole lab under a new folder called `graded_lab_2` in your existing repository.
Refer to the following [Submission Guide](./submission_guide.md) for more details

# Graded Lab 2 (100 points = 3.33% weight)

## Prerequisites
* Unity is installed and set up.
* Github repo already set up for submissions.
* Get the starting project from this repo: [https://github.com/abdullahzen/game-programming-labs](https://github.com/abdullahzen/game-programming-labs) Folder is called GradedLab2

# Task 1: Bugs Fixing (35 points)
1. Balls are going through the pockets and their walls. (Currently, there are no walls behind the halls)
2. Balls are moving very fast on the table. (the table or balls seem to have little to no resistance)
    - Do **NOT** change the max force/speed set in the script. You need to modify different resistance force properties until it looks realistic. (Hint: Dynamic friction, Drag, Angular Drag, Bounciness)

# Task 2: Simple Scoring System (50 points)
Implement a simple scoring system with the following specifications:
* When the 8 ball enters a pocket, a Debug message is printed indicating "Game Over" and then a restart of the game is triggered.
* When the white ball enters a pocket, only the white ball's position is reset to its starting position.
* When any colored/striped ball enters a pocket, a score is incremented by 1. (No distinction needs to be made between striped/solid balls).

# Bonus Task: (30 bonus points)
* Balls can fly off the table sometimes. (Hint: we want to do something so none of the balls could fly off the table or lift a bit off the table). (The solution for this one should not be a complex one - it is a simple one).
* Move the pool stick relative to the white ball without compromising the animation's positions. (Hint: some manipulations of animation and/or manipulation of gameobject hierarchies could be required).


# Organization of Github and project + Precision (15 points)

# Submission
Submit the whole lab under one folder in your existing labs repository.
Refer to the following [Submission Guide](./submission_guide.md) for more details

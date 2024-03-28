# Graded Lab 3

## Prerequisites
* The starting project is the same solution of the Lab 5 Solution, check your Mio for downloading it quickly.
* Clone your git repository that you use to submit your graded labs
* Create a new folder called: `graded_lab_3`
* Copy and extract the file you downloaded into that folder
* Load the project in unity


# Task 1
> Although it is not required, it is good practice to create the main menu in a separate scene.  

> Tip: it's good practice to have one separate script for all actions of the main menu 

* Create a main menu with the following:
    * Start Game: Ball and arm should be hidden and only appear/spawn after start game is pressed. Pressing start game should load the scene.
    * Options: pops up another menu which contains:
        * A slider to control the volume level of the game. 
    * Quit: exits the game
* Game should pause when `Esc` is pressed on the keyboard and the following menu should appear:
    * Resume Game: resumes the game.
    * Main Menu: restarts the game.
* (Bonus) Look for a clicking sound effect on the internet and import it to the project
* (Bonus) Play the clicking sound whenever the mouse is clicking a button on the menu

# Task 2
* Implement a simple scoring system (already exists in code) and display the score with the number of hits on the top right corner of the screen:
    * The score should reflect the number of pins fallen.

# Task 3
* Implement a nice UI layout to show a victory sign of your choice at the end of the game when all pins have fallen right before the game restarts.

# Task 4 (Bonus)
* Implement a nice UI showing a Game Over sign, if the player takes more than 5 tries in hitting all the bowling pins.

# References
- [https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/index.html](https://docs.unity3d.com/Packages/com.unity.ugui@1.0/manual/UICanvas.html)
- https://abdullahzen.github.io/game-programming-docs/ 

# Submission
Commit all your changes to your existing Git repo.  
If you don't have a git repo for submission, follow the [submission guide](./submission_guide.md) 

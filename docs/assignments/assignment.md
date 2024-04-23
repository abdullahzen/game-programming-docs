# Assignment: Devilion
**Weight: 12% (Bonus) | Deadline: 11:59pm Wednesday, May 22nd, 2024**

## Prerequisites and rules
* Download the starting project: https://1drv.ms/u/s!AvNVN__FAFfyhJpolnsVBdpDMPOCJA?e=OpcpQ8
* Copy Assignment into your own folder/repository (make sure you create a new repository for this assignment)
* Load the project into unity
> Most needed assets are included except for a few images and sounds. 
* Copying components as-is between projects will be considered plagiarism and will result in a score of 0 on this assignment. All components that are not included in this project should be created from scratch.
* Partial marks will not be given unless more than 50% of a feature/task is complete. (majority of a feature)

# Task 1: Main menu
* Create a main menu which contains the following buttons:
    * Start Game: starts the actual game and loads everything into the scene.
    * Options: pops up a submenu with the following:
        * Character starting health level.
        * Difficulty of level: Easy, Medium, Hard. (controls the number of enemy NPCs to spawn)
    * Exit: restarts the scene or exits the game.
* Pressing ESC at any point in the game pauses the game and brings up a menu with Reume button and a main menu button to go back to the start.

# Task 2: Map and colliders
* Add the proper colliders are to all the components to make the game playable. 
* Player (Hero) should be able to rest on top of the floor, should be able to step down or up any staircases.
* Add a water pond in one of the three floors.
* Player should be able to walk through water. (This pond will be used in subsequent tasks)

# Task 3: Input System
* Create an indirect input system to have the inputs of the game controlled through Actions and events.
    * WASD or Arrows should be used for movements, along with mouse clicks.
    * Space bar should jump.
    * Weapons can be switched using numbers (1-2).
    * Q is used to hit NPC enemies to make damage whenever the player (hero) is in range.

# Task 4: Sounds
* Add sounds to the following:
    * Water splashing (pond)
    * Weapon swining
    * Walking footsteps
    * Background music
    * Dynamic music that changes based on the number of spawned NPC enemies (linked with difficulty selected in the options menu)
    * Healing sound
    * Collapsing/breaking/dying/screaming sound

# Task 5: Particle System
* Create a particle system to have the effect of a fire magic spell and add it to be as one of the weapons to be selected by the player (hero) that would throw.
* A healing circle near the end of the level to heal the main player. 
 
# Task 6: Weapons switching
The player can have the following weapons:
* Sword (number 1 key binding)
* Fireball magic spell (number 2 key binding)

# Task 7: Animations
* Create animation for the decoy prefab to be used for all spawned enemies of an attack stance.

# Task 8: Navmesh and NPC range
When the main player gets close to the NPC range, the NPC will start moving towards the player and start applying damage to the player at regular intervals while it is alive.
* Player can attack enemies without attracting them from a distance by using the fireball magic spell. (Player would be out of melee range here)
* Player has to get in melee range to attack the enemies with the sword

# Task 9: Scores and Winning
Implement a scoring system to keep track of how many enemy NPCs were killed.
Once all NPCs are killed, the main door should open and passing through it should prompt a victory sign.
A player can die and get a game over sign, if the player's health reaches 0.

# References
- https://abdullahzen.github.io/game-programming-docs/ 

# Submission
* Create a new Github repository for this assignment and push it there by the deadline.
* Invite me to the new repository. 
* Send me a Mio indicating you submitted the assignment.
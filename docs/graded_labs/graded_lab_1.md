# Graded Lab 1 (Weight 5%)

> This is a graded lab and submission is required. The lab should be done in pairs and only one submission is required.

## Prerequisites
* Unity is installed and set up.
* A github repo is already set up for submissions.

# Tasks
1. Download and extract the following .zip file which contains the starting project:
    - [project](https://1drv.ms/u/s!AvNVN__FAFfyg9h54VvR6KgG9TslhA?e=bstPJ6)
1. After extraction is complete, open th project from disk in the UnityHub by selecting the project folder:
![alt text](../images/graded_lab_1_0.png)

1. Create a mini bowling game with the following sepcifications:
    1. Pins should rest at the end of a bowling alley
    1. Ability to throw the ball on the bowling alley towards the pins
    1. The ball should tumble pins it collides with.
    1. Space bar should throw the ball (the throw is not projectile.)
    1. Holding the space bar sould determine the force of the ball. Holding the space bar for a longer time should increase the throw force.
    1. Mass of the ball can be increased/decreased using the up arrow and the down arrow buttons.
    1. Changing the mass of the ball using the arrows should change the color of the ball.
        - Example: a ball of mass 1-15 should have a yellow color, a mass of 16-25 should have a green color, and a mass of 26 or greater should have a black color.
        - Hint:
            ```c#
            var currentRenderer = GetComponent<Renderer>();
            currentRenderer.material.SetColor("_Color", Color.black);
            // Other colors are available with static access as well https://docs.unity3d.com/2021.3/Documentation/ScriptReference/Color.html
            ```
    1. The game should "reset" after the ball leaves the wood floor:
        - A new bowling ball should respawn at the initial position a few seconds after the ball leaves the wood floor. The old ball should be destroyed after a few seconds as well. [Destroy() docs](https://docs.unity3d.com/2021.3/Documentation/ScriptReference/Object.Destroy.html)
        - Pins should be respawned at their initial position.
    1. Bonus: Set a dynamic max speed as a threshold calculated based on a ratio relative to the mass of the bowling ball to avoid the case of an excessive speed that is faster than the physics engine discrete properties.

# Submission
Refer to the following [Submission Guide](./submission_guide.md) for more details

type beam fully ignore
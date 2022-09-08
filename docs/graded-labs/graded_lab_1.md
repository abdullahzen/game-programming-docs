# Graded Lab 1

## Prerequisites
* Unity is installed and set up.
* Github repo already set up for submissions.

# Task 1
1. Create a new empty 3D project from Unity Hub
1. Download and extract the following .zip files which contain your assets:
    - [assets](https://1drv.ms/u/s!AvNVN__FAFfygddy3XzxNEobLJA-YQ?e=zrzmT5)
1. After extraction is complete, import all your assets into your Unity Project. or copy them under the folder `Assets`
    - ![image](https://docs.unity3d.com/2017.2/Documentation/uploads/Main/sketchup1.png)
    - Select the model file `.fbx`, `.dae` or `.obj`
    - Re-import and select all the textures images
> Textures are not attached to the models as materials by default when you import external assets. You need to drag and drop the `.jpg` or `.png` image from your project view in the lower pane to the corresponding model in the hierarchy pane.
4. Now you should have the building blocks to start the task.
5. Create a mini bowling game with these sepcifications:
    - Pins should rest at the end of a bowling alley
    - Ability to throw the ball on the bowling alley towards the pins
    - The ball should tumble pins it collides with
    - Make it as realistic as in real life
    - Physics must be taken into account. i.e a higher mass ball effect on the pins should be higher than a lower mass ball.
    - Space bar should throw the ball (the throw is not projectile. It's like a trigger with force.)
    - Holding the space bar sould determine the force of the ball
    - Mass of the ball can be increased/decreased using up arrow and down arrow. 
    - Changing the mass of the ball using the arrows should change the material of the ball.
        - Example: a ball of mass 1-15 should have normal material, a mass of 15-25 should have the roughness material, and a mass of 25 or greater should have metallic material. 
    - Escape button should restart the game (without going out of game view)
    - Set a dynamic max speed as a threshold calculated based on a ratio relative to the mass of the bowling ball to avoid the case of an excessive speed that is faster than the physics engine discrete properties.



# Submission
Refer to the following [Submission Guide](./submission_guide.md) for more details

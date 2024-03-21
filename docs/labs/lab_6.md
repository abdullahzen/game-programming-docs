# Lab 6: More on Animations

The goal of today's lab is to be able to animate a robot (humanoid type character)
We will import a Robot asset from the unity asset store, and then apply some animations to achieve the following states/animations:
* Standing Idle
* Walking
* Jumping
* Laying down

# Tasks and Steps

* Go to Unity asset store and add the asset to unity: (https://assetstore.unity.com/packages/3d/characters/robots/robot-kyle-urp-4696)[https://assetstore.unity.com/packages/3d/characters/robots/robot-kyle-urp-4696]
* Drag and drop the robot to the scene, create its material from the textures and apply it on the robot. 
* Create an account on Mixamo: (https://www.mixamo.com/)[https://www.mixamo.com/]
* Upload the character .fbx model located in your Assets/UnityTechnologies/.../Model 
* Wait for Auto-rigging. Reminder: Rigging a character is mapping a skeleton to the character to enable us to assign animations to it based on that skeleton. 
* Download the desired animation from the website with the following options: 
    * format: FBX for Unity 
    * Skin: without skin 
* Drag and drop the downloaded model into your Assets folder in Unity for it to load. 
* Re-rig the character in Unity as a "Humanoid" type by clicking on the model you downloaded 
* This character animation is ready to use now. 
* Create a new AnimationController (right click in the project view and click Create) 
* Add a new "Animator" component to the robot in your scene, then attach the AnimationController to it. 
* Double click on the AnimationController under your assets and start creating the different states
* Each state represents an animation clip or motion that the character has to do.
* Movements between states are done with a flow-like diagram in the AnimaionController where a state represents the animation and a transition represents the possible scenarios.
* Transitions can have conditions as well 

# Submission
**No Submission is required for this lab** 
 

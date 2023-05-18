# CSCI321-Labs
Labs created in my game development class.

## Lab 1 [https://barrynn.itch.io/lab-1]
We were supposed to focus on white boxing an obstacle course. We were also tasked to script character movement as well as register when the player finished
the course, and a trigger to 'respawn' the player. 
  
As I had some experience in unity before I added a few extra things to the course such as faling platforms, moving platforms, and jumping. To respawn the player would need to hit 'r' on their keyboard.
  

## Lab 2 [https://barrynn.itch.io/lab-2]
We were supposed to build off of lab 1 and make the course more interactive. We were tasked with adding more structure and enviroments to the course as well as 
add a door that is supposed to be opened with a key.

I chose to represent the course as platforms over a lava bed, messing around with terrain and paint for the first time. The key should be picked up when the player walks over it and the door disappear when approached with the key.
  

## Lab 3 [https://barrynn.itch.io/lab-3]
We were tasked with adding animation to our course. We need to have the player represented with a rigged 3D model, set up the animator controller based on player
inputs, add a door animation (such as a pivot), and add some sort of obstacle that uses physics.

I chose a model from a site recommended to us by our professor that included models and animations. As I had obstacles that used physics in lab 1, I did not need to add anything in that regard. The door recieved a pivot animation that should play when the player approaches the door and presses 'q'. The player animations are a tiny bit odd, but this was a first attempt at animation and we had just begun learning about it.
 
 
## Lab 4 [https://barrynn.itch.io/lab-4]
Did not continue using the obstacle course made in the previous 3 labs. In this lab we were tasked with creating an AI that would use a NavMesh to navigate around
the world to patrol an area of at least 2 points. We also need to animate the AI.

I used the site from the previous lab to get the model and animations and created a patrol path of at least 4 points. The AI should stop at each point and "look around" before continuing to the next point. If the player hits 'o' they can view the map at an overview angle and be able to see the AI move around easier. To revert back to the original camera, the player just needs to hit 'm'. 

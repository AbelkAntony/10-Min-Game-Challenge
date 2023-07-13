# ESCAPE
 
The game is that the player have a white ball at the middle of the screen . The ball can be move around the black circle located in the center of the game screen . 
At a fixed time interval hexagon spawn from the outside the game window and shirk . 
One side of the hexagon is open. 
The player need to move around the ball to get escape from the hexagon without ball touch on the hexagon .
If the ball collide with the hexagon the game will restart from the beginning . I add rigid body to both ball and hexagon . 
Also add circle collider 2d to ball to detect if the ball collide with hexagon . 
I use SceneManager.LoadScene function to restart the game when the ball collide with hexagon.

Freatures
- Movement arond the axis for ball
- Hexagon spwan in different angle
- Shrink hexagon towards center
- Destroy hexagon at a fixed point


https://user-images.githubusercontent.com/122546743/234297796-093bfdb4-76c8-400c-a501-be11607755c9.mp4



#ScreenShots

![Capture1](/ScreenShots/1.png)
![Capture1](/ScreenShots/2.png)
![Capture1](/ScreenShots/3.png)

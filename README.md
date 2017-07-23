Unity version : 5.5.1



RESUBMIT:

-updated to include 5 randomly placed coins (took a while and pretty sure there is a better way of moving through the list I made)
-changed coins to not only float with mathf.sin but also spin.  this was actually a better implimenation as I no longer have to track the posiition of the coin in oder to orient the quaternions in the right direction.
-updated to use public Door door;




Note:

added 'floating' feature to collectables using mathf.sin()

DEVIATION FROM RUBRIC:

Instead of adding multiple coins around the map, I thought it would be more interesting to implement a SpawnCoin script that randomly spawns a coin in 1 of the 6 predefined posistions I made.  that way you don't know exactly where the coin upon start.



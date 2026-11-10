# in-class-activities
## Devlogs
### W1
When I move the Camera off of the Cat GameObject, the cat would move but the camera wouldn't move with the cat anymore as it's not a child of the Cat anymore.
https://blazersun.itch.io/w1-cat-activity 

### W2
1. The r, g, and b variables are floats instead of int, bools, or strings is because the values are all fractions for RGB.
2. The _bounce variable is an int because it's a tracker for how many times the ball bounced. You can't do 2.4 bounces so you use whole number to track the amount of bounces and to do that you would use int.
3. The reason the code had an error was because there wasn't an ";" at the end of the code, creating the error.

### W3
Table #2
Activity 1
1. String GetResponse(int choice, int friendshipLevel, bool secret)
2. void SetLightDimness(int sanityLevel)
3. bool DidPlayerHitBeat(float accuracy)

Activity 2
Class: Taco shell
Compoenent: Full taco (from **Taco Bell**)
Member variables: Ingredients
Methods: How you want the taco

Activity 3
I think the reason for the balls brightness getting brighter and brighter with every bounce is because the brightness is being multiplied by a certain amount every bounce making it brighter and brighter.

### W4
Table #2

1. The Goal was the one that need the "Is Trigger" checkmarked as it will allow the ball to pass through it. The ball and cat needed the rigid bodies so that they can hit each other and bounce off the walls.

2. When the cat was rotating as I was moving it, I looked over the instructions again and once I went through them again I fixed the mistake.

### W5
1. Needs 2 member variables
  - First one is the NavMeshAgent class
    - NavMeshAgent: lets you use the .SetDestination method to set where the deer wants to go.
      - It doesn’t care where it is originally, only really cares about where it’s destination is.
  - Second variable type is Transform class
    - It lets it tell the variable the location of the goal
2. The class needs the Start() method. 
3. The method should set the destination to the position of our object we want to choose. For this instance, we want the deer to go to the cat.

###W6

### W7
Activity 1
 I worked on the math category
 https://docs.google.com/document/d/1C6uCwfuqZOueFMv-xBgh9KSqakfdi0eeqCGhbDev6XM/edit?tab=t.0#heading=h.nw8cf7ozohf6 
Activity 2
- Set up the BatW6 Class
  - Goal: Make the bats move toward the player when chasing is enabled.
  - Member Variables: used _speed (to control how fast the bat moves), _isChasing (a true/false flag to check if it should move), and _playerTransform (to find where the player is)
  - Method used
    - Start(): Finds and caches the player's position using their tag.
    - Update(): Constantly moves the bat toward the player using Vector3.MoveTowards() if _isChasing is true.
    - StartChasing() & StopChasing(): Public methods that let BatManager turn the chasing behavior on or off.
- Set up the BatManager
  - Distance Checks: BatManager loops through all the bats in the _bats array every frame to measure the distance between each bat and the player.
  - Delegating Control: If the player is close enough (within _interactDistance), BatManager calls StartChasing(). If the player is too far away, it calls StopChasing()
  - Reactions & UI: When a bat gets close enough to overlap (_overlapDistance), BatManager picks a random message from the _messages array and spawns a reaction text bubble on the bat.
###W8

###W9

###W10

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 

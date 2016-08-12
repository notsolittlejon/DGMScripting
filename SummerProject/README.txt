Readme

This game was created by me (Jonathan Hardy).

I did not create the character models or their accompanying animations. 
These were found in the unity asset store, at the links below.

Sword: https://www.assetstore.unity3d.com/en/#!/content/67902
Troll: https://www.assetstore.unity3d.com/en/#!/content/18219
Shaman: https://www.assetstore.unity3d.com/en/#!/content/59073
Guard: https://www.assetstore.unity3d.com/en/#!/content/15209

With the exception of these, I made the rest of the game.




-----------------------------------------------
Tony,

I built as much as I could off of my midterm project to make something 
bigger and better for the final in this class. I really learned a lot
and pushed myself a lot farther than I thought I could go. 

I did my best to annotate my project so that you could decipher what
I was trying to do with all my lovely code.

To make your life maybe a bit easier, I tried to explain below how I 
felt that I met (or failed to meet) the project requirements listed
in Canvas. 

I did make an windows Executable form of my game, though I couldn't make an
accompanying one for Mac. It's found in the Build folder if you want to try it out

Thanks,

	-Jonathan Hardy




For meeting Final Project requirements:

1. 	Variables - Yep, I have lots of them. 

2. 	Functions - I made several, some class-specific, and some in the 
	main project class as well.

3. 	If Statements - A great deal of my project relies on these, 
	checking for player and enemy health and acting accordingly

4. 	Loops - I used a couple of loops, one for updating the Inventory 
	text in the GUI and one for resetting enemies to full health if you 
	die.

5. 	Scope and Access Modifiers - I have several classes that call on
	each other at times. There are separate classes for Powerups, 
	Players, and Enemies. Enemies even are assigned a powerup that they drop.

6.	Arrays - Truth be told, I only have one array that holds all the enemies
	in the game. This seemed fitting, since I knew the set number of enemies
	that would be in the game

7. 	Lists - I only had one List in my project, just the Inventory. it seemed
	fitting to have an item that could grown and shrink so easily as needed. 

8. 	Enums - I had one Enum in this project, called State. The various States
	included Loading, Beginning, Attacking, and so on. I relied heavily on 
	these to make my project work properly.

9. 	Switch Statements - I only had one, the StoryProgression switch statement
	in this project. I modified it heavily to rely on a variable (counter)
	and a great deal of If statements (especially the Beginning case), but 
	it worked like a charm. 

10.	Text-Based Console Game - I added a GUI, but it was still just a text
	based game at heart.

11.	Create Power Ups 

		a. With User Interaction - Well, I suppose I failed on this point.
		Once you picked up the powerup it permanently altered your
		character
		
		b. Add to a Variable - This much I did. The sword added to
		strength, the potion added to speed, and the shield to 
		defense.

		c. Adds an Inventory Item - Picking up each item did add it to
		the inventory, which was displayed in the GUI.

12. 	Create a function that can solve a math problem - For this, I just had a
	couple of functions for checking speed or defense of the character, and 
	trigger an event based on what happened. For example: I had one function 
	For charming an enemy. It would add the player charisma and intelligence
	and compare it to the added char/int of the enemy. If the player's was
	higher, it the charm was successful. If it was lower, the enemy would 
	attack.

13.	Loop and Add Inventory Items - Yeah, I didn't do this one either. I just
	used the .Add function to add items to the inventory list, because it 
	worked better for me than using a loop. Unless you count looping to add
	inventory items to the GUI, which I definitely did. 

14. 	Use instances and references - I did this quite often, as it made many 
	of my functions more multipurpose. I was able to just make one function
	that could do a lot just by telling it what enemy object to reference.

15. 	Short code - I tried on this one, I really did. I still ended up with 
	a pretty big amount of code considering how short my game is, especially
	with all my comments.


		

/*
Write a Text-Based program (game):

Requirements are:
------------------
-Variables
-Functions
--One function must solve a math problem (Add/Subtract)
-If Statements 
-Loops
--One loop must add bonus inventory items
-Scope and access modifiers
-Create Power-Ups


Problem solve the following:

Create power-ups that must
---------------------------
-User interaction. (Trigger, Click)
-Add to a variable (health, ammo)

Create power-up that
-----------------------
-Adds an inventory item 

Create a function that can solve a math problem
-------------------------------------------------
-Add numbers
-Subtract numbers

Create a function that runs with a certain answer (If answer is 10 for example, something happens);
----------------------------------------------------------------------------------------------------
-Loop and add bonus inventory items

Use SHORT CODE (:/)

*/
using UnityEngine;
using System.Collections;



public class Midterm : MonoBehaviour
{
	
	/*
	public float strength = Random.Range(1,10);
	public int dexterity = Random.Range(1,10);
	public int intelligence = Random.Range (1,10);
	public int charm = Random.Range(1,10);
	*/

	//void OnMouseDown --> Continue?
	//Click to continue? (Input.anyKeyDown)

	//pseudocode!

	/*

Beginning of the story! 





-----------------------

Encounter Two (Switch Statement?)
After getting past the troll, you continue in the dungeon and find a locked door.
You can:
-Pick the lock (Dexterity & Intelligence)
-Break down the door (Strength, check inventory for sword and add +5 to score if it's there)
-Knock and see who is there (Charisma & Intelligence)

If you fail, you lose hp
(Fail to pick lock, too noisy, guard opens door and it smacks you in the face)
(Fail to break door, guard swings door open and hits you with it)
(Knock and fail, the guard opens the door and hits you with it)

If you succeed: 
-Quietly open door, and proceed
-Break the door in, and proceed

------------------------------
Encounter Three (Switch Statement)
Get past the guard, and out of the dungeon!
-Talk to the guard (Charisma + Intelligence)
-Run past the guard (Dexterity + strength)
-Fight the guard (Strength, check inventory for sword and add +5 to score if it's there)

if you 
fail, lose hp
(fail to charm guard, he attacks you and you have to run. if dexterity is too low, he hits you as you run past)
(fail to run past him, he hits you as you go by)
(fail when fighting him, test defense and he does damage if your dexterity is too low)

if you succeed, 
-Guard opens the gate and lets you out of the dungeon
-You run past the guard, open the gate and flee the dungeon
-You defeat the guard and he opens the gate for you, allowing to flee the dungeon. 

Victory Statement: It is unclear who threw you in this strange dungeon or why, but at least you are free again--for now. 
Death: As your blurred vision begins to fade, you question who would have thrown you in this accursed dungeon and why. Looks like you'll never know. 

*/
	public PlayerStats player1;
	public Weapon[] Inventory;
	public int StoryOption = 1;

	void Setup ()
	{
		//Randomly picks player initial stats
		player1.InitializePlayer (Random.Range (1, 10), Random.Range (1, 10), Random.Range (1, 10), Random.Range (1, 10));
	}
		

	void Story ()
	{
		if (StoryOption == 1) {
			print ("Welcome, hero!");
			print ("In the dead of night, you were abducted and left down in a deep dungeon. Oh no.");
			print ("Click the sphere to continue");
		}

		//Encounter One (Switch Statement?)
		//In the dead of night, were abducted and left down in a deep dungeon. Oh no. 
		//You encounter a troll, who somehow got a hold of your beautiful greatsword.
		//You can 
		//-Attack (Adds Strength & Defense)
		//-Run (Adds Strength & Dexterity)
		//-Charm (Adds Charisma and Intelligence)

			else if (StoryOption == 2) {
			print ("---------------------------------------------------------------------------------------------------------------");
			print ("While trying to find your way out, you encounter a troll. It somehow got a hold of your beautiful greatsword.");
			print ("To Attack, set StoryOption to 3.");
			print ("To Run, set StoryOption to 4.");
			print ("To Charm, set StoryOption to 5.");
			//If you fail, you lose hp.
			//(Attack, troll throws you)
			//(Run, you don't get away. He smacks you and throws you.)
			//(Charm, unimpressed, he picks you up and throws you)

				//If you succeed, you gain 1 item (Greatsword, added to Inventory)
				//(Attack, you hit him and he drops it and runs)
				//(Run, you steal it and run away)
				//(Charm, he gives it to you)
		} else if (StoryOption == 3) {
			
		} else if (StoryOption == 4) {
			
		} else if (StoryOption == 5) {
			
		} else if (StoryOption == 6) {
			
		}


	}




 	

	void Start ()
	{
		
		





	
	}


	void Update ()
	{
		Story ();
	}
}

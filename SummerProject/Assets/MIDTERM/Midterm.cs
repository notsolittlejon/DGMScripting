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
using System.Collections.Generic;
public class Midterm : MonoBehaviour
{
	public int page = 1;
	public PlayerStats player1;
	Weapon b_greatsword = new Weapon();
	//public Weapon[] inventory = new Weapon[5];
	public List<Weapon> inventory = new List<Weapon>();
	public int trollStrength;
	//These variables make sure the loops only run once, while allowing for constant input. 
	private int n1 = 0;
	private int n2 = 0;
	private int n3 = 0;
	private int n4 = 0;
	private int n5 = 0;
	//private int n6 = 0;

	void Setup ()
	{
		//Randomly picks player initial stats
		player1.InitializePlayer (Random.Range (1, 10), Random.Range (1, 10), Random.Range (1, 10), Random.Range (1, 10));
		trollStrength = (Random.Range (4,9));
	}
	//The Powerup!
	void FindSword ()
	{
		b_greatsword.SpawnWeapon ("Beautiful Greatsword",5, 10);
		inventory.Add(b_greatsword);
		//The sword permanently increases your health. Whoo. 
		player1.WeaponPowerup (b_greatsword.WeaponStrength ());
		print ("Your sword has increased your Strength by 5, for a total of " + player1.GetStrength ());
	}
	void ShowHealth ()
	{
		//Health is displayed. 
		print ("Health: " + player1.health);
	}
	void TrollHit ()
	{
		//You check your defense against the troll's attack, and take whatever damage your defense doesn't block
		player1.health -= player1.DefenseChecker (trollStrength);
		print ("The troll picks you up and deftly throws you.");
		print ("You manage to scramble away after recovering from the fall.");
		ShowHealth ();
	}
	//Here is where the bulk of the story is to be found. 
	void Story ()
	{
		if (page == 1) {

			while (n1 < 1) {
				//Effectively the "Title Page" of our little adventure.
				print ("Welcome, hero!");
				print ("In the dead of night, you were abducted and left down in a deep dungeon. Oh no.");
				print ("Select page 2 to continue.");
				n1++;
			}
		}
		//Encounter One
		else if (page == 2) {
			while (n2 < 1) {
				print ("---------------------------------------------------------------------------------------------------------------");
				print ("While trying to find your way out, you encounter a troll. It somehow got a hold of your beautiful greatsword.");
				print ("To Attack, select page 3.");
				print ("To Run, select page 4.");
				print ("To Charm, select page 5.");
				//If you fail, you lose hp.
				//If you succeed, you gain 1 item (Greatsword, added to Inventory
				n2++;
			}
			//You decide to attack!
		} else if (page == 3) {
			//Loop to only let this happen once. 
			while (n3 < 1) {
				print ("You attempt to attack the great troll.");
				//-Attack (Adds Strength & Defense)
				//If the attack succeeds...
				if (player1.AttackSuccss (trollStrength)) {
					print ("You pick up a rock and chuck it as hard as you can. Direct hit! The troll falls unconcsious.");
					print ("You take your sword from the monstrous troll, and continue further into the dungeon.");
					FindSword ();
					//If the attack fails...
				} else {
					print ("You try taking a swing at it, but the troll just stares at you as your blows bounce off its thick skin.");
					TrollHit ();
				}
				n3++;
			}
		} else if (page == 4) {
			//Run (Adds Strength & Dexterity)
			while (n4 < 1) {
				print ("You attempt to sprint past the troll, hoping it will be slow enough that it won't be able to reach you.");
				//If running succeeds...
				if (player1.RunSuccess (trollStrength)) {
					print ("You manage to slip past the lumbering creature with ease, snatching your greatsword out of its hands as you go by");
					FindSword ();
					//If running fails...
				} else {
					print ("You try to run past the lumbering beast, but it manages to get a hold of your arm as you flit past.");
					TrollHit ();
				}
				n4++;
			}
		} else if (page == 5) {
			while (n5 < 1) {
				print ("You attempt to reason with the great brute. Maybe it's just misunderstood?");
				//If charming succeeds..
				if (player1.CharmSuccess (trollStrength)) {
					print ("Turns out you two have lots in commmon. You even both have an uncle Fred. Crazy!");
					print ("The Troll explains that it thought you were dead, which is why it took your sword. It gladly returns it to you.");
					FindSword ();
					//If charming fails...
				} else {
					print ("It is much harder to reason with a troll than you expected. Your efforts seem to be in vain.");
					TrollHit ();
				}
				n5++;
			}
		}

		//Function for showing what's in the inventory
		/*
		else if (page == 6){
			while (n6 < 1) {
				foreach(Weapon element in inventory){
					print (element.WeaponName());}
				n6++;
			}
		}*/
	}


	void Start ()
	{
		Setup ();
	}


	void Update ()
	{
		Story ();
	}
}

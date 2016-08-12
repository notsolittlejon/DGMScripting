using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Final : MonoBehaviour
{
	
	public Player player1;
	public GameObject level;
	public GameObject monster1;
	public GameObject monster2;
	public GameObject monster3;
	public GameObject stand1;
	public Button attackB;
	public Button charmB;
	public Button runB;
	public Button contB;
	public Text story;
	public Text stats;
	public Text monsterStats;
	public Text inventoryText;
	public List<Powerup> inventory = new List<Powerup> ();
	public Enemy troll = new Enemy ();
	public Powerup sword = new Powerup ();
	public Enemy guard = new Enemy ();
	public Powerup shield = new Powerup ();
	public Enemy wizard = new Enemy ();
	public Powerup potion = new Powerup ();
	Enemy[] enemyRoster = new Enemy[3];
	//The counter variable triggers a lot of story events and such, used heavily along with the Enum
	public int counter = 0;
	public int damageDealt = 0;
	public int damageTaken = 0;

	//Displays updated player stats, including health and such.
	void FetchStats ()
	{
		//Won't allow the player to go below 0 health. 
		if (player1.health < 0) {
			player1.health = 0;
		}
		stats.text = "HEALTH - " + player1.health + "\n\nStrength --- " + player1.strength + "\nDefense --- " + player1.defense + "\nSpeed ------ " + player1.speed + "\nCharisma - " + player1.charisma + "\nIntelligence - " + player1.intelligence;
	}

	//This prints out the inventory to the GUI
	void FetchInventory ()
	{
		inventoryText.text = "Inventory\n---------------------\n";
		//Adds each item in the inventory list to the inventory text box
		foreach (Powerup element in inventory) {
			inventoryText.text += (element.name) + "\n";
		}


	}

	//This will update the monster stat box with fresh info about the enemy
	public void EnemyUpdate (Enemy _m)
	{
		//Won't allow monster health to drop below zero
		if (_m.health < 0) {
			_m.health = 0;
		}
		monsterStats.text = _m.monster + "\n\nHealth ---- " + _m.health + "\n\nStrength ----- " + _m.strength + "\nSpeed -------- " + _m.speed + "\nCharisma --- " + _m.charisma + "\nIntelligence - " + _m.intelligence;


	}

	//displays all assets except the continue button
	void activate ()
	{
		attackB.gameObject.SetActive (true);
		charmB.gameObject.SetActive (true);
		runB.gameObject.SetActive (true);
		stand1.gameObject.SetActive (true);
		contB.gameObject.SetActive (false);
		//Changes which monster is displayed on each activation
		if (counter < 100) {
			monster1.gameObject.SetActive (true);
		} else if ((counter < 200) && (counter > 99)) {
			monster2.gameObject.SetActive (true);
		} else if ((counter < 300) && (counter > 199)) {
			monster3.gameObject.SetActive (true);
		}
	}

	void deactivate ()
	{
		//hides everything but the continue button
		monster1.gameObject.SetActive (false);
		monster2.gameObject.SetActive (false);
		monster3.gameObject.SetActive (false);
		attackB.gameObject.SetActive (false);
		charmB.gameObject.SetActive (false);
		runB.gameObject.SetActive (false);
		stand1.gameObject.SetActive (false);
		contB.gameObject.SetActive (true);
	}

	//Initially sets up the game
	void setup ()
	{
		deactivate ();
		//randomly selects character stats, adding up to a total of 20 between them all
		int s = Random.Range (1, 10);
		int d = Random.Range (1, 16 - s);
		int c = Random.Range (1, 16 - (s + d));
		int i = (20 - (s + d + c));
		player1.InitializePlayer (s, d, c, i);
		//filling in the details on all the enemy and powerup classes
		//Also adding enemies into their array
		sword.SpawnPowerup ("Sword", "+5 boost to Strength");
		troll.InitializeEnemy ("Troll", 10, 5, 2, 1, 2, 2, 100, sword);
		shield.SpawnPowerup ("Shield", "+5 boost to defense");
		enemyRoster [0] = troll;
		guard.InitializeEnemy ("Guard", 5, 5, 5, 2, 3,2,1234, shield);
		enemyRoster [2] = guard;
		potion.SpawnPowerup ("Potion", "+5 boost to speed");
		wizard.InitializeEnemy ("Wizard", 3, 3, 4, 2, 8, 1, 200, potion);
		enemyRoster [1] = wizard;
		monsterStats.text = "";
		//Initial story text is displayed.
		story.text = "Welcome, Hero! \n\nYou awaken in the depths of a rank dungeon.\n\nWho could have put you down in here, and why?\n\nPress button to continue....";	
		FetchStats ();
		FetchInventory ();
	}



	//Updates the story text with how much damage was dealt by either side
	public void DamageUpdate ()
	{
		story.text = "You dealt " + damageDealt + " damage.\n\nYou took " + damageTaken + " damage.";
	}

	//This will reset the health of the monsters if the player dies, so they can try again.
	public void ReviveMonsters ()
	{
		//Each enemy in the array has their health reset to 20.
		foreach (Enemy foe in enemyRoster) {
			foe.health = 20;
		}
	}

	//When the Attacking switch is initiated, this function runs. 
	public void AttackingMonster (Enemy _a)
	{
		//Player deals damage based on their strength
		damageDealt = _a.DefenseChecker (player1.strength);
		_a.health -= damageDealt;
		//Enemy stats updated to show damage
		EnemyUpdate (_a);

		//If the enemy still has health left
		if (_a.health > 0) {
			//Enemy then attacks
			//Player has a chance to dodge
			float heroDodge = (Random.Range (1, player1.speed));
			//Player Dodges
			if (heroDodge >= _a.speed) {
				//No damage taken
				damageTaken = 0;
			//Player doesn't dodge
			} else {
				//Reduce damage done by defense level, and then take excess damage
				damageTaken = player1.DefenseChecker (_a.strength);
				player1.health -= damageTaken;
				//Update player stats to show changes to health
				FetchStats ();
			}
			;
			//If the player still has health left
			if (player1.health > 0) {
				//Update player stats
				FetchStats ();
				//Display how much damage was dealth and taken by the player
				DamageUpdate ();
				//Change game state to move the switch statement back to Beginning
				State.gameState = State.States.Beginning;
				//Add to the counter, so that the initial enemy reveal is not repeated, but the enemy is still visible to attack, charm, etc.
				counter++;
				//prompt again to attack, run or charm
			//If the player is out of health
			} else {
				State.gameState = State.States.Dying;
				//You DIE!!
				story.text = "You died.";
			}
			;
		//If the enemy is out of health
		} else {
			story.text = "You defeated the " + _a.monster + ", and pick up a " + _a.special.name + " off his dead corpse.\n\nIt gives you a " + _a.special.ability;
			//Counter is updated to move to the next enemy encounter
			counter = _a.counter;
			//Powerup added to inventory
			inventory.Add (_a.special);
			//inventory updated
			FetchInventory ();
			deactivate ();
			//Clear monster stats text box
			monsterStats.text = "";
			//Adds the powerup ability to the player, depending on what they just defeated.
			if (counter == 100) {
				//If they just defeated the troll, they get the sword
				player1.PickupSword ();
			} else if (counter == 200) {
				//If the Shaman is defeated, they get a potion
				player1.PickupPotion ();
			} else if (counter == 1234) {
				//If the guard is defeated, they get a shield
				player1.PickupShield ();
			}
			//Stats are updated for the player
			FetchStats ();
			//Back to the beginning switch to continue the story. Whoo!
			State.gameState = State.States.Beginning;
		
		}
		;

	}

	//If you try to charm the enemy...
	public void CharmingMonster (Enemy _a)
	{
		//Checks if your intelligence and charisma excel that of the target. If it is...
		//You succeed!
		if (player1.CharmSuccess (_a.intelligence, _a.charisma)) {
			story.text = "You managed to sweet talk the " + _a.monster + " with your silver tongue.\n\nYou were given a " + _a.special.name + ", giving you a " + _a.special.ability;
			//Powerup added
			inventory.Add (_a.special);
			FetchInventory ();
			deactivate ();
			//Monster stats set to null
			monsterStats.text = "";
			//counter updated to the next enemy
			counter = _a.counter;
			//Different powerup given for each enemy charmed
			if (counter == 100) {
				//Troll gives you a sword
				player1.PickupSword ();
			} else if (counter == 200) {
				//Shaman gives you a potion
				player1.PickupPotion ();
			} else if (counter == 1234) {
				//Guard gives you a shield
				player1.PickupShield ();
			}
			//stats are updated for player
			FetchStats ();

			//State set back to the beginning switch
			State.gameState = State.States.Beginning;

		//Fail to charm? Well that makes it angry and it attacks
		} else {
			//Chance to dodge
			float heroDodge = (Random.Range (1, player1.speed));
			if (heroDodge >= _a.speed) {
				//No damage taken, but also no dealt out
				damageDealt = 0;
				damageTaken = 0;
			//If you were too slow...
			} else {
				damageDealt = 0;
				//Reduce damage done by defense level, and then take damage
				damageTaken = player1.DefenseChecker (_a.strength);
				player1.health -= damageTaken;
				FetchStats ();
			}
			;
			//If you still have health left
			if (player1.health > 0) {

				FetchStats ();
				story.text = "You failed to charm the " + _a.monster + ", and it deals " + damageTaken + " damage to you, knocking you back.";
				State.gameState = State.States.Beginning;
				counter++;
				//prompt again to attack, run or charm
			//If you're out of health
			} else {
				
				//You DIE!!
				story.text = "You died. Not charming enough I guess.";
				State.gameState = State.States.Dying;
			}
			;
		}
	}

	//This will be what runs for the Running switch statement. 
	//Note: Successful run does not grant powerup
	public void RunningMonster (Enemy _a)
	{//If you're speedy enough...
		if (player1.RunSuccess (_a.speed)) {
			story.text = "You ran right past the " + _a.monster + " , quick as lightning!";
			deactivate ();
			monsterStats.text = "";
			counter = _a.counter;
			State.gameState = State.States.Beginning;
		//if you're too slow, you're attacked
		} else {
			//Chance to dodge
			float heroDodge = (Random.Range (1, player1.speed));
			if (heroDodge >= _a.speed) {
				damageTaken = 0;
				damageDealt = 0;
			} else {
				damageDealt = 0;
				//Reduce damage done by defense level, and then take damage
				damageTaken = player1.DefenseChecker (_a.strength);
				player1.health -= damageTaken;
				FetchStats ();
			}
			;
			//If you still have health left
			if (player1.health > 0) {
				
				FetchStats ();
				story.text = "You were too slow to get past the " + _a.monster + ", and it deals " + damageTaken + " damage to you, knocking you back.";
				State.gameState = State.States.Beginning;
				counter++;
				//prompt again to attack, run or charm
			//If you ran out of health...
			} else {
				State.gameState = State.States.Dying;
				//You DIE!!
				story.text = "You died. TOO SLOW!";
			}
			;
		}
	}


	//Switch statement that allows the story to progress. Ties in to the State enum class.
	public void StoryProgression ()
	{
		switch (State.gameState) {
		case State.States.Loading:

			break;
		case State.States.Beginning:
			activate ();
			//Depending on the counter setting, you encounter a different enemy. 
			//Initial encounter on setup is the troll
			if (counter == 0) {
				EnemyUpdate (troll);
				story.text = "While trying to find your way out, you encounter a troll. It somehow got a hold of your beautiful sword.\n\nThe fiend!\n\nWhat do you do?";
			} 
			//If you get past the troll, this screen appears
			else if (counter == 100) {
				deactivate ();
				story.text = "You continue further into the dungeon, hoping to find an escape.";
				counter++;
			} 
			//Second encounter: Shaman
			else if (counter == 101) {
				EnemyUpdate (wizard);
				story.text = "You've encountered a grouchy barbarian Shaman. He doesn't look too friendly.";
			} 
			//If you get past the Shaman, this appears.
			else if (counter == 200) {
				deactivate ();
				story.text = "You move deeper into the dungeon. Maybe your eyes are just adjusting to the dark, but it seems brighter in here.";
				counter++;
			} 
			//Third encounter: Guard
			else if (counter == 201) {
				EnemyUpdate (guard);
				story.text = "It looks like you've found the exit! However, there is an armed guard blocking the way.\n\nHe looks ready for some action.";

			} 
			//If you get past the Guard, this appears.
			else if (counter == 1234) {
				deactivate ();
				story.text = "You still have no idea who captured you, but at least you're free of the dungeon.\n\nThe End....for now.";
				counter++;
			} else if (counter == 1235) {
				Application.Quit ();

			}
			;
			break;
		//If the attack button is selected, this will run, and you encounter a different enemy based on what the counter is at
		case State.States.Attacking:

			//Depending on the counter, the corresponding enemy is attacked
			if (counter <= 99) {
				AttackingMonster (troll);
			} else if ((counter > 99) && (counter < 199)) {
				AttackingMonster (wizard);
			} else if ((counter > 199) && (counter < 299)) {
				AttackingMonster (guard);

			}
			break;
		//Runs when Charm button is activated
		case State.States.Charming:
			//Depending on the counter, corresponding enemy is charmed
			if (counter <= 99) {
				CharmingMonster (troll);
			} else if ((counter > 99) && (counter < 199)) {
				CharmingMonster (wizard);
			} else if ((counter > 199) && (counter < 299)) {
				CharmingMonster (guard);

			}
			break;
		case State.States.Running:
			//Depending on counter, corresponding enemy is ran away from
			if (counter <= 99) {
				RunningMonster (troll);
			} else if ((counter > 99) && (counter < 199)) {
				RunningMonster (wizard);
			} else if ((counter > 199) && (counter < 299)) {
				RunningMonster (guard);

			}
			break;
		case State.States.Dying:
			//if your health hits zero, you are switched over to this. 
			//Inventory items are removed, monsters are revived, and the game is reset
			//You keep your same stats though.
			monsterStats.text = "";
			story.text = "As your vision fades to black, you think sadly that you'll never be able to find out who put you in this cursed dungeon, or why. \n\n YOU DIED\\n\\nClick Continue to try again.";
			inventory.Clear ();
			deactivate ();
			ReviveMonsters ();
			counter = 0;
			break;
		//If you survive everything, the final messages is displayed (seen at the bottom of the "Beginning" switch, for when you defeat the guard
		case State.States.Ending:
			monsterStats.text = "";
			deactivate ();
			counter = 1234;
			break;

		}

	}

	//Code for the Continue button
	public void ContinueOnClick ()
	{
		State.gameState = State.States.Beginning;
		StoryProgression ();
	}

	//Code for Attack button
	public void AttackOnClick ()
	{
		State.gameState = State.States.Attacking;
		StoryProgression ();

	}

	//Code for Charm button
	public void CharmOnClick ()
	{
		State.gameState = State.States.Charming;
		StoryProgression ();
	}

	//Code for Run button
	public void RunOnClick ()
	{
		State.gameState = State.States.Running;
		StoryProgression ();
	}

	void Start ()
	{
		
		setup ();
		StoryProgression ();

	}
}

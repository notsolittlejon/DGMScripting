using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Final : MonoBehaviour
{
	public Player player1;
	public GameObject level;
	public GameObject monster1;
	public GameObject stand1;
	public Button attackB;
	public Button charmB;
	public Button runB;
	public Button contB;
	public Text story;
	public Text stats;
	public Text monsterStats;
	public List<Powerup> inventory = new List<Powerup> ();
	public Enemy troll = new Enemy ();
	public Enemy guard = new Enemy ();
	public Enemy wizard = new Enemy ();
	Enemy[] enemyRoster = new Enemy[3];
	public int counter = 0;
	public int damageDealt = 0;
	public int damageTaken = 0;


	void FetchStats ()
	{
		if (player1.health < 0) {
			player1.health = 0;
		}
		stats.text = "HEALTH - " + player1.health + "\n\nStrength --- " + player1.strength + "\nDexterity -- " + player1.dexterity + "\nSpeed ------ " + player1.speed + "\nCharisma - " + player1.charisma + "\nIntelligence - " + player1.intelligence;
	}

	void activate ()
	{
		//displays all assets except the continue button
		monster1.gameObject.SetActive (true);
		attackB.gameObject.SetActive (true);
		charmB.gameObject.SetActive (true);
		runB.gameObject.SetActive (true);
		stand1.gameObject.SetActive (true);
		contB.gameObject.SetActive (false);
	}

	void deactivate ()
	{
		//hides everything but the continue button
		monster1.gameObject.SetActive (false);
		attackB.gameObject.SetActive (false);
		charmB.gameObject.SetActive (false);
		runB.gameObject.SetActive (false);
		stand1.gameObject.SetActive (false);
		contB.gameObject.SetActive (true);
	}

	void setup ()
	{
		deactivate ();
		int s = Random.Range (1, 10);
		int d = Random.Range (1, 16 - s);
		int c = Random.Range (1, 16 - (s + d));
		int i = (20 - (s + d + c));
		player1.InitializePlayer (s, d, c, i);
		troll.InitializeEnemy ("Troll", 2, 3, 1, 1, 0);
		enemyRoster [0] = troll;
		guard.InitializeEnemy ("Guard", 4, 9, 1, 1, 0);
		enemyRoster [2] = guard;
		wizard.InitializeEnemy ("Wizard", 1, 7, 2, 5, 0);
		enemyRoster [1] = wizard;
		monsterStats.text = "";
		story.text = "Welcome, Hero! \n\nIn the dead of night, you were abducted and awoke in the depths of a gloomy dungeon. \nHow dreadful.\n\nPress Button to continue....";	
		FetchStats ();
	}

	public void TrollUpdate(){
		if (troll.health < 0) {
			troll.health = 0;
		}
		monsterStats.text = "Troll\n\nHealth: " + troll.health;

	}

	public void DamageUpdate(){
		story.text = "You dealt " + damageDealt + " damage.\n\nYou took " + damageTaken + " damage.";
	}

	public void StoryProgression ()
	{
		switch (State.gameState) {
		case State.States.Loading:
			print ("Starting Out");
			break;
		case State.States.Beginning:
			activate ();
			if (counter == 0) {
				TrollUpdate ();
				story.text = "While trying to find your way out, you encounter a troll. It somehow got a hold of your beautiful greatsword.\n\nThe fiend!\n\nWhat do you do?";
			} else if (counter >= 100){
				deactivate ();
				story.text = "Yay! You defeated it.\n\nYou pick up your shiny sword and add it to your inventory.";

			}
			;
			break;
		case State.States.Attacking:

			damageDealt = troll.DefenseChecker (player1.strength);
			troll.health -= damageDealt;
			TrollUpdate ();

			if (troll.health > 0) {
			//Troll then attacks
				float heroDodge = (Random.Range (1, player1.speed));
				if (heroDodge >= troll.speed) {
					//Troll missed
				} else {
					//Reduce damage done by defense level, and then take damage
					damageTaken = player1.DefenseChecker (troll.strength);
					player1.health -= damageTaken;
					FetchStats ();
				};
				if (player1.health > 0) {
					
					FetchStats ();
					DamageUpdate ();
					State.gameState = State.States.Beginning;
					counter++;
					//prompt again to attack, run or charm
				} else {
					State.gameState = State.States.Dying;
					//You DIE!!
					story.text = "You died.";
				};

			} else {
				story.text = "You defeated the troll!";
				deactivate ();
				monsterStats.text = "";
				counter = 100;

			//End the encounter, troll is defeated
			//player gains powerup
			}
			;
			break;
		case State.States.Charming:
			break;
		case State.States.Running:
			break;
		}


	}


	public void ContinueOnClick ()
	{
		print ("Continue Clicked");
		State.gameState = State.States.Beginning;
		StoryProgression ();
	}

	public void AttackOnClick(){
		State.gameState = State.States.Attacking;
		StoryProgression ();

	}

	void Start ()
	{
		
		setup ();
		StoryProgression ();


	}
	// Update is called once per frame
	void Update ()
	{
		//StoryProgression ();
	}


}

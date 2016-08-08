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
	public List<Powerup> inventory = new List<Powerup> ();
	public Enemy troll = new Enemy ();
	public Enemy guard = new Enemy ();
	public Enemy wizard = new Enemy ();
	Enemy[] enemyRoster = new Enemy[3];
	public int counter = 0;


	void FetchStats ()
	{
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
		troll.InitializeEnemy ("Troll", 10, 3, 1, 1, 3);
		enemyRoster [0] = troll;
		guard.InitializeEnemy ("Guard", 4, 9, 1, 1, 2);
		enemyRoster [2] = guard;
		wizard.InitializeEnemy ("Wizard", 1, 7, 2, 5, 1);
		enemyRoster [1] = wizard;
		story.text = "Welcome, Hero! \n\nIn the dead of night, you were abducted and awoke in the depths of a gloomy dungeon. \nHow dreadful.\n\nPress Button to continue....";	
		FetchStats ();
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
				story.text = "While trying to find your way out, you encounter a troll. It somehow got a hold of your beautiful greatsword.\n\nThe fiend!\n\nWhat do you do?";
			} else {
				story.text = "The troll still blocks the way. What do you do?";
			}
			;
			break;
		case State.States.Attacking:
			//Attack troll!
			//Check the troll's speed against yours
			float trollDodge = (Random.Range (1, troll.speed));

			if (trollDodge >= player1.speed) {
				//Show "You Missed!" if the troll is fast enough
			} else {
				//troll loses health after defense blocks damage
				troll.health -= troll.DefenseChecker (player1.strength);
			}


		
			if (troll.health > 0) {
			//Troll then attacks
				float heroDodge = (Random.Range (1, player1.speed));
				if (heroDodge >= troll.speed) {
					//Troll missed too
				} else {
					//Reduce damage done by defense level, and then take damage
					player1.health -= player1.DefenseChecker (troll.strength);
				};
				if (player1.health > 0) {
					State.gameState = State.States.Beginning;
					counter++;
					//prompt again to attack, run or charm
				} else {
					State.gameState = State.States.Dying;
					//You DIE!!
				};

			} else {
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
		print ("Clickity Click");
		State.gameState = State.States.Beginning;
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

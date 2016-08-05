using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Final : MonoBehaviour
{

	public GameObject level;
	public GameObject monster1;
	public GameObject stand1;
	public Button attackB;
	public Button charmB;
	public Button runB;
	public Button contB;
	public Text story;
	public Text stats;
	private int counter = 0;


	public Player player1;

	void FetchStats(){
		stats.text = "HEALTH - " + player1.GetHealth () + "\n\nStrength --- " + player1.GetStrength () + "\nDexterity -- " + player1.GetDexterity () + "\nSpeed ------ " + player1.GetSpeed () + "\nCharisma - " + player1.GetCharisma ();
	}

	void setup ()
	{

		monster1.gameObject.SetActive (false);
		attackB.gameObject.SetActive (false);
		charmB.gameObject.SetActive (false);
		runB.gameObject.SetActive (false);
		stand1.gameObject.SetActive (false);
		contB.gameObject.SetActive (true);
		player1.InitializePlayer (Random.Range (1, 10), Random.Range (1, 10), Random.Range (1, 10), Random.Range (1, 10));
		story.text = "Welcome, Hero! \n\nIn the dead of night, you were abducted and awoke in the depths of a gloomy dungeon. \nHow dreadful.\n\nPress Button to continue....";	
		FetchStats ();
	}



	void StoryProgression()
	{
		

	}


	void Start ()
	{
		
	setup ();
	


	}

	public void StartThisGame ()
	{
		//contB.OnSelect(State.States = State.States.Beginning);
	}



	// Update is called once per frame
	void Update ()
	{
		
	}
}

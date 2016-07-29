using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Final : MonoBehaviour {

	Monster Troll = new Monster();
	Monster Guard = new Monster();


	Monster[] monsterArray = new Monster[4];
	List<Monster> monsterList = new List<Monster>();

	void ListEm(){
		foreach (Monster aMonster in monsterList) {
			print (aMonster.monsterName);
		}
	}

	void ListEmArray(){
		foreach (Monster aMonster in monsterArray ){
			print (aMonster.monsterName);
		}
	}


	// Use this for initialization
	void Start () {
		Troll.Spawn ("Troll");
		//Troll.Initialize ();

		Guard.Spawn ("Guard");
		//Guard.Initialize ();
		monsterList.Add (Troll);
		monsterList.Add (Guard);
		monsterArray [0] = Troll;
		monsterArray [1] = Guard;
		ListEm ();
		monsterList.Remove (Troll);
		ListEm ();
		monsterList.Remove (Guard);
		ListEm ();
		ListEmArray ();




	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

﻿using UnityEngine;
using System.Collections;

public class Multiplayer : MonoBehaviour {
	
	public HealthData player1;
	public HealthData[] players;

	void Start (){
		foreach (HealthData _hd in players) {
			print (_hd.username + " " + _hd.Strength);
			int playerDefense = _hd.TakeDownDefense ();
			print (playerDefense);
		}
	}
}


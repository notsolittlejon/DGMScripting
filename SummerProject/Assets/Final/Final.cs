using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Final : MonoBehaviour {

	public GameObject level;
	public GameObject monster1;
	public Button attackB;
	public Button charmB;
	public Button runB;
	public Button contB;
	public Text story;
	public Text stats;
	public enum gameState {Attacking, Charming, Running};




	void Start () {

		monster1.gameObject.SetActive (false);
		attackB.gameObject.SetActive (false);
		charmB.gameObject.SetActive (false);
		runB.gameObject.SetActive (false);
		contB.gameObject.SetActive (true);





	}
	public void StartThisGame(){
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

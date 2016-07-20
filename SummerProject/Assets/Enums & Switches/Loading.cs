using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Loading : MonoBehaviour {

	public GameObject startButton;
	private Text screenText;

	private int countdown = 5;

	IEnumerator LoadGame(){
		while (countdown > 0) {
			screenText.text = "Loading... " + countdown;
			yield return new WaitForSeconds (1);
			countdown--;
		}

		screenText.text = "Ready To Play";
		yield return new WaitForSeconds (1);

		GameStates.currentGameState = GameStates.States.Starting;
		startButton.SetActive (true);
		gameObject.SetActive (false);
	}


	// Use this for initialization
	void Start () {
		startButton.SetActive (false);
		screenText = GetComponent<Text> ();
		StartCoroutine (LoadGame ());
	}
	

}

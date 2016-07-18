using UnityEngine;
using System.Collections;

public class EachLoops : MonoBehaviour {
	public int[] playerScores;
	// Use this for initialization
	void Start () {
		foreach (int _score in playerScores) {
			//_score += 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

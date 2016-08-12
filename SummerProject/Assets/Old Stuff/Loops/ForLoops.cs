using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour
{

	public int[] playerScores;

	void Start ()
	{
		for (int i = 0; i < (playerScores.Length - 1); i++) {
			playerScores [i] += 10;
		}
	}

	void Update ()
	{
	
	}
}

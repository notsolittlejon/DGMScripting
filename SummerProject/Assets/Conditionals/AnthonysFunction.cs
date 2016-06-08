using UnityEngine;
using System.Collections;

public class AnthonysFunction : MonoBehaviour
{
	public string username1 = "Jonathan";
	public string username2 = "William";
	public bool test = true;

	float Addition (float _a, float _b)
	{
		return _a + _b;
	}


	string Phrase ()
	{
		string Phrase = username1 + ", you win!";
		return Phrase;
	}

	string Winner (string _a, string _b)
	{
		string winner;
		if (test == true) {
			winner = _a;
		} else {
			winner = _b;
		}
		return winner + " is the winner!";
	}

	void Start ()
	{
		//print (Addition (0.15f, 0.35f));
		//print(Phrase());
		print (Winner (username1, username2));
	}


	void Update ()
	{
	
	}
}

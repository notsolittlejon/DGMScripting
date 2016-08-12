using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour
{

	//Add the names in unity
	public string[] myFamily;
	string familyArray;

	void WhileLoop(){
		int i = 1;
		while (i++ < 10) {
			Debug.Log ("While Loop");
		}

	}

	void DoWhileLoop(){
		int h = 1;
		do {
			Debug.Log ("Do Loop ");
			h++;
		} while (h < 6);

	}

	void ForLoop(){
		for (int j = 1; j <= 5; j++) {
			Debug.Log ("For Loop ");
		}

	}

	void ForEachLoop(){
		foreach (string _familyName in myFamily) {
			familyArray += (_familyName + " loves ");
			print (familyArray);
		}
	}
	void Start ()
	{
		WhileLoop ();
		DoWhileLoop ();
		ForLoop ();
		ForEachLoop ();
	}

}

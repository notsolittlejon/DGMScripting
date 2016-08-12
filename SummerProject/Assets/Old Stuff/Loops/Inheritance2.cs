using UnityEngine;
using System.Collections;

public class Inheritance2 : MonoBehaviour {

	public BaseAmmo thisAmmo;

	
	// Update is called once per frame
	void Update () {
		thisAmmo.Fire ();
	}
}

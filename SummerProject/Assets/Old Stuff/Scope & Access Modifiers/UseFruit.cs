using UnityEngine;
using System.Collections;

public class UseFruit : MonoBehaviour {

	private ScopeAccess MyFruit;

	// Use this for initialization
	void Start () {
		MyFruit = new ScopeAccess ();
		MyFruit.AddApples (10);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class ScopeAccess {

	private int apples = 10;
	private int oranges = 5;
	public int bananas;

	public void AddApples(int _moreApples){
		apples += _moreApples;
	}

	public void AddOranges (int _moreOranges){
		oranges += _moreOranges;

	}

	public void AddFruit(int fruit1, int fruit2, int fruit3)
	{int grapes = 1;
		int salad = grapes + fruit1 + fruit2 + fruit3;
		Debug.Log (salad);
	}


	// Use this for initialization
	void Start () {
		apples = 20;
		Debug.Log (apples);
		//V--------------This one won't work, because "grapes" are only visible to the AddFruit function. Wahoo. 
		//print (grapes);
		AddFruit(apples, oranges, bananas);
	}
	
	// Update is called once per frame
	void Update () {

	}
}

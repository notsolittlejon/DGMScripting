using UnityEngine;
using System.Collections;

public class Branch1 : MonoBehaviour {
	int branch1 = 3;
	int branch2 = 3;
	int branch3 = 3;
	//Simulates merging two branches. How creative. 
	int Merge (int _alpha, int _bravo){
		return _alpha + _bravo;
	}
	//-------------------------------------
	void Start () {
		print (Merge (branch1, branch2));
		print (Merge (branch3, branch3));
	}

	
	// Update is called once per frame
	//void Update () {
	
	//}
}

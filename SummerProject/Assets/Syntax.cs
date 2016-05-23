using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour{

	int myInt;

	int MyInt(int _i, int _j){
		return _i+_j;
	}

	void Start (){
		myInt = MyInt (10,4);
		print (myInt);
	}


}
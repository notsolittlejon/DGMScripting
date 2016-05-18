using UnityEngine;
using System.Collections;

public class Vars2 : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	//	print ("Hello World");
	//}
	
	// Update is called once per frame
	//void Update () {
	//	print ("Update");
	//}

	int jelly=1;
	int honey=5;
	int peanutButter=3;

	float jellyJar = 0.5f;
	float honeyJar = 1.7f;
	float pbJar = 3.987f;

	string jellyFlavor = "Grape";
	string honeyFlavor = "Clover";
	string pbStyle = "Creamy";

	int MixIngredients(int ingredient1, int ingredient2){
		return ingredient1+ingredient2;
	}

	float biggestJar(float jar1,float jar2, float jar3){
		var a = jar1;
		var b = jar2;
		var c = jar3;
		var d = 0;

		if ((a > b) && (a > c)) {
			return jar1;
		} else if ((b > a) && (b > c)) {
			return jar2;
		} else if ((c > b) && (c > a)) {
			return jar3;
		} else {
			return d;
		}
	}


	//Actually spitting out some data! How exciting.
	void Start(){
		print (MixIngredients (peanutButter, honey));
		print (MixIngredients (peanutButter, jelly));
		print (MixIngredients (peanutButter, peanutButter));
		print (MixIngredients (jelly, honey));
		print ("The largest containter is "+biggestJar (jellyJar, honeyJar, pbJar)+" ounces.".ToString());
	}

}

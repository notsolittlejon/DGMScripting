using UnityEngine;
using System.Collections;

public class Vars2 : MonoBehaviour {
	


	//Here are some cute global variables for us to use. 

	//Bread types. Yummy.
	//string bread1 = "white";
	//string bread2 = "wheat";
	//string bread3 = "sourdough";
	//string bread4 = "rye";

	//Sweetness ratings, the highest possible value being a 1.0
	float honeySweetness = 0.9f;
	//float jellySweetness = 0.7f;
	float pbSweetness = 0.3f;


	//On a scale from 1-5 (one being worst, 5 being best)
	//int jellyRating = 3;
	int honeyRating = 5;
	int pbRating = 2;

	//Jar capacities in Ounces. 
	float jellyJar = 0.5f;
	float honeyJar = 1.7f;
	float pbJar = 3.987f;

	//Flavor names. Fun for making titles. 
	string jellyFlavor = "Grape";
	string honeyFlavor = "Clover";
	string pbStyle = "Creamy";

	//Colors of ingredients. Maybe a fun if/else statement could be used to mix colors...if I was really bored enough
	//string jellyColor = "Purple";
	string honeyColor = "Amber";
	//string pbColor = "Tan";

	//Now, on to the functions! Wheee!

	//Designed to show the biggest size of jar that's out there. Use with one of the Jar variables. 
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

	//Just mixes together the names of ingredient flavors to make a cutesy title. Use with one of the flavor variables. 
	string sandwichTitle(string flavor1, string flavor2, string flavor3){
		string a = "This is a " + flavor1 + " " + flavor2 + " " + flavor3 + " sandwich.";
		return a;
	}

	//Gives a sandwich a rating out of 10. Use with one of the Rating variables. 
	int sandwichRating(int ingredient1, int ingredient2)
	{
		int a = ingredient1;
		int b = ingredient2;

		return a + b;

	}

	//This is designed to make a lovely sentence out of the sandwich rating. Yeah, I know...it could have just all been one function. But then I couldn't call a function in a function in a function! 
	//Use with the sandwichRating function, in case that wasn't clear. 
	string sandwichRatingString(int score){
		return "This sandwich is rated " + score + " out of 10.";
	}

	//Simply returns the name of the ingredient color. Use with one of the Color variables. 
	string ingredientColor(string color){
		return "This ingredient is " + color + ".";
	}

	//Gives a sandwich a sweetness rating out of 2.0. Use with Sweetness variables.
	string sandwichSweetness(float ingredient1, float ingredient2){
		float sweetness = ingredient1 + ingredient2;
		return "This sandwich has a sweetness rating of " + sweetness + " out of 2.0.";

	}
	//---------------------------------------------------------------------------------------------//

	//Actually spitting out some data! How exciting.
	void Start(){
		print ("The largest containter is "+biggestJar (jellyJar, honeyJar, pbJar)+" ounces.".ToString());
		print (ingredientColor (honeyColor));
		print (sandwichTitle (pbStyle, jellyFlavor, honeyFlavor));
		print (sandwichSweetness (pbSweetness, honeySweetness));
		print (sandwichRatingString (sandwichRating (pbRating, honeyRating)));
	}

	// Update is called once per frame
	//void Update () {
	//	print ("Update");
	//}
}


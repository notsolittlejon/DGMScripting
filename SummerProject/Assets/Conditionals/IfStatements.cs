using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
	public bool myBool = true;
	public int myInt = 150;
	public string username = "unityunicorn";
	public string password = "conquertheworld";
	const string adminUsername = "admin";
	const string adminPassword = "masterandcommander";

	string GreaterThanOne (int a)
	{
		if (a > 1) {
			return ("This number is greater than one.");
		} else if (a == 1) {
			return ("This number is one.");
		} else {
			return ("This number is less than one.");
		}
	}

	string GateChecker (int b)
	{
		if (b > 0 && b < 10) {

			return ("Open the Gates!");
		} else {
			return ("Close the Gates!");
		}
	}

	string LessThanZero (int c)
	{
		if (c < 0) {
			return ("This number is less than zero.");
		} else if (c == 0) {
			return ("This number is zero.");
		} else {
			return ("This number is greater than zero.");
		}

	}
	string login(string a, string b){
		if (a == "unityunicorn" && b == "conquertheworld") {
			return ("Login Accepted. Welcome, code master.");
		} else if (a == adminUsername && b == adminPassword) {
			return ("Login Accepted. Welcome, administrator.");
		} else
			return ("Credentials invalid. Please try again.");
	}
	//________________________________________________________
	void Start ()
	{
		print (GateChecker (myInt));
		print (GreaterThanOne (myInt));
		print (LessThanZero (myInt));
	}
	
	//_________________________________________________________
	void Update ()
	{
		print (GateChecker (myInt));
		print (GreaterThanOne (myInt));
		print (LessThanZero (myInt));
		print (login (username, password));
	}
}
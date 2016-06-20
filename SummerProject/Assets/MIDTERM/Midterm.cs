/*
Write a Text-Based program (game):

Requirements are:
------------------
-Variables
-Functions
--One function must solve a math problem (Add/Subtract)
-If Statements 
-Loops
--One loop must add bonus inventory items
-Scope and access modifiers
-Create Power-Ups
-

Problem solve the following:

Create power-ups that must
---------------------------
-User interaction. (Trigger, Click)
-Add to a variable (health, ammo)

Create power-up that
-----------------------
-Adds an inventory item 

Create a function that can solve a math problem
-------------------------------------------------
-Add numbers
-Subtract numbers

Create a function that runs with a certain answer (If answer is 10 for example, something happens);
----------------------------------------------------------------------------------------------------
-Loop and add bonus inventory items

*/
using UnityEngine;
using System.Collections;



public class Midterm : MonoBehaviour
{
	
	public string userName = "Type your name here";
	public float strength = Random.Range(1,10);
	public int dexterity = Random.Range(1,10);
	public int intelligence = Random.Range (1,10);
	public int charm = Random.Range(1,10);

	void StoryIntro ()
	{
		string part1 = "Welcome to this revolutionary text-based adventure. If you haven't done so yet, please input your name in the UserName field, so we can begin.";
		print (part1);

	}




	// Use this for initialization
	void Start ()
	{
		StoryIntro ();
		//CharacterCreation (strength, dexterity, intelligence, charm);

	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

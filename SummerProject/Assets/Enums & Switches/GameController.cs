using UnityEngine;
using System.Collections;

namespace Introduction
{
	public class GameController : MonoBehaviour
	{
		void ChangeGame ()
		{
			switch (MyEnums.gameState) {
			case MyEnums.gameStates.Starting:
				print ("Starting");
				break;

			case MyEnums.gameStates.Playing:
				print ("Playing");
				break;

			case MyEnums.gameStates.Ending:
				print ("Ending");
				break;

			}
		}
		void Start (){
			ChangeGame ();
		}

		void OnMouseDown ()
		{
			MyEnums.gameState = MyEnums.gameStates.Playing;
			ChangeGame ();
		}
	}
}

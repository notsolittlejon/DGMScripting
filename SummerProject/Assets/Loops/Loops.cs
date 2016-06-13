using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour
{

	//Add the names in unity
	public string[] myFamily;
	string familyArray;

	void Start ()
	{
		foreach (string _familyName in myFamily) {
			familyArray += (_familyName + " loves ");
			print (familyArray);
		}

	}

}

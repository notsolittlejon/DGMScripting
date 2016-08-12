using UnityEngine;
using System.Collections;

public class Movewithwhileloop : MonoBehaviour {
	public float xDistance = 10;
	Vector3 pos; 

	IEnumerator MoveInX(){
		while (pos.x <= xDistance){
			pos.x += 0.1f;
			print ("while Loop");
			transform.position = pos;
			yield return new WaitForSeconds(0.1f);
		}
		print ("Stop");
	}

	void Start(){
		StartCoroutine (MoveInX());
	}
	void Update(){
		//This is bad. Don't do this-----v
		//---------------------------
		//if (pos.x <= xDistance){
		//pos.x += 0.1f;
		//print (pos.x);
		//}
		//--------------------------
		if(transform.position.x <= 10){
			transform.Translate(0.1f, 0,0);}

	}

}

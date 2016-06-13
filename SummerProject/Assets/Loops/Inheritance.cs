using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseAmmo {
	//This controls the amount of ammo and power level of ammo.
	public int ammoCount;
	public int ammoPower;

	public void Fire(){
		if (ammoCount > 0) {
			ammoCount--;
			Debug.Log (ammoCount);
		} else {
			Debug.Log ("Out of Ammo");
		}

	}
}

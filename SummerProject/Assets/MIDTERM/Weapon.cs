[System.Serializable]
public class Weapon {
	public string name;
	public int strength; 
	public int weight;

	//initially sets up weapon
	public void SpawnWeapon(string _n, int _s, int _w){
		name = _n; 
		strength = _s;
		weight = _w;

	}
	public int WeaponStrength(){
		int i = strength;
		return i;
	}

	public string WeaponName(){
		return name;
	}

}
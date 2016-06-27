[System.Serializable]
public class Weapon {
	string name;
	int strength; 
	int weight;

	public void SpawnWeapon(string _n, int _s, int _w){
		strength = _s;
		weight = _w;
	}

}
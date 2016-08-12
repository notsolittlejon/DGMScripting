[System.Serializable]

public class Powerup {
	public string name;
	public string ability;


	public void SpawnPowerup(string _n, string _a){
		name = _n;
		ability = _a;
	
	}
}

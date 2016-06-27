[System.Serializable]
public class PlayerStats {
	
	//User Data 
	//-Name (String)
	public string username;
	//-Health
	public int health = 20;
	//Strength (Int)
	public int strength;
	//Dexterity (Int)
	public int dexterity;
	//Charisma (Int)
	public int charisma;
	//Intelligence (Int)
	public int intelligence;
	//Defense (Int)
	private int defense = 2;


	public void InitializePlayer(int _s, int _d, int _c, int _i){
		strength = _s;
		dexterity = _d;
		charisma = _c;
		intelligence = _i;
	}
	public int DefenseChecker(int damage){
		if (defense >= damage) {
			damage = 0;
			return damage;
		} else {
			return damage - defense;
		}
			
	}
}

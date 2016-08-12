[System.Serializable]

public class Enemy{
	
	//-Name (String)
	public string monster;
	//-Health
	public int health = 20;
	//Strength (Int)
	public int strength;
	//Dexterity (Int)
	public int dexterity;
	public float speed;
	//Charisma (Int)
	public int charisma;
	//Intelligence (Int)
	public int intelligence;
	//Defense (Int)
	public int defense = 2;
	public int counter;
	public Powerup special;

	//Initially sets up player.
	public void InitializeEnemy (string _n, int _s, int _d, int _sp, int _c, int _i, int _df, int _co, Powerup _p)
	{
		monster = _n;
		strength = _s;
		dexterity = _d;
		speed = _sp;
		charisma = _c;
		intelligence = _i;
		defense = _df;
		counter = _co;
		special = _p;
	}

	//Checks character defense against incoming damage. Damage is negated or reduced, depending on defense level
	public int DefenseChecker (int damage)
	{
		if (defense >= damage) {
			damage = 0;
			return damage;
		} else {
			return damage - defense;
		}

	}

}

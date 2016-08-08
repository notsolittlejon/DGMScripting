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

	//Initially sets up player.
	public void InitializeEnemy (string _n, int _s, int _d, int _c, int _i, int _df)
	{
		monster = _n;
		strength = _s;
		dexterity = _d;
		speed = ((_d - _s) * (_d - _s))*.1f;
		if (speed < 1) {
			speed = 1;
		}
		charisma = _c;
		intelligence = _i;
		defense = _df;
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
	//Checks strength & dexterity against monster strength. Returns true if you are strong and fast enough to deal damage
	public bool AttackSuccss (int heroStrength)
	{
		if ((strength + dexterity) > heroStrength) {
			return true; 
		} else {
			return false;
		}

	}
		

	//Adds weapon's strength to hero's strength permanently
	public void WeaponPowerup(int wstrength){
		strength += wstrength;
	}

	public int GetStrength(){
		int i = strength;
		return i;
	}

	public int GetDexterity(){
		int i = dexterity;
		return i;
	}

	public float GetSpeed(){
		float i = speed;
		return i;
	}

	public int GetCharisma(){
		int i = charisma;
		return i;
	}

	public int GetIntelligence(){
		int i = intelligence;
		return i;
	}

	public int GetHealth(){
		int i = health;
		return i;
	}


}

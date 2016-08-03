[System.Serializable]
public class PlayerStats
{
	
	//User Data
	//-Name (String)
	public string username;
	//-Health
	public int health = 20;
	//Strength (Int)
	public int strength;
	//Dexterity (Int)
	public int dexterity;
	public int speed;
	//Charisma (Int)
	public int charisma;
	//Intelligence (Int)
	public int intelligence;
	//Defense (Int)
	private int defense = 2;

	//Initially sets up player.
	public void InitializePlayer (int _s, int _d, int _c, int _i)
	{
		username = "Our Hero";
		strength = _s;
		dexterity = _d;
		speed = ((_d - _s) * (_d - _s));
		charisma = _c;
		intelligence = _i;
		if (speed == 0) {
			speed++;
		}
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
	public bool AttackSuccss (int monsterStrength)
	{
		if ((strength + dexterity) > monsterStrength) {
			return true; 
		} else {
			return false;
		}

	}
	public bool RunSuccess (int monsterStrength){
		//Create monster speed (Subtract 10 from the strength and then square it. For my intents, this will cause weaker monsters to be faster.
		int monsterSpeed = (monsterStrength - 10) * (monsterStrength - 10);
		if ((speed) > monsterSpeed)
			return true;
		else
			return false;
	}

	public bool CharmSuccess (int monsterStrength){
		int monsterBrains = monsterStrength * 2;
		if ((charisma + intelligence) > monsterBrains)
			return true;
		else
			return false;
	}

	//Adds weapon's strength to hero's strength permanently
	public void WeaponPowerup(int wstrength){
		strength += wstrength;
	}

	public int GetStrength(){
		int i = strength;
		return i;
	}

}


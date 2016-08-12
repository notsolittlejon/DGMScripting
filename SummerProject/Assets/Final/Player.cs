[System.Serializable]
public class Player
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
	public float speed;
	//Charisma (Int)
	public int charisma;
	//Intelligence (Int)
	public int intelligence;
	//Defense (Int)
	public int defense = 2;


	//Initially sets up player.
	public void InitializePlayer (int _s, int _d, int _c, int _i)
	{
		username = "Our Hero";
		strength = _s;
		dexterity = _d;
		speed = ((_d - _s) * (_d - _s))*.1f;
		if (speed < 1) {
			speed = 1;
		}
		charisma = _c;
		intelligence = _i;
		if (speed == 0) {
			speed++;
		}
	}

	//Checks character defense against incoming damage. Damage is negated or reduced, depending on defense level
	public int DefenseChecker (int damage)
	{
		//If the defense is greater than damage dealth, damage is 0
		if (defense >= damage) {
			damage = 0;
			return damage;
		} 
		//Otherwise, return the damage minus the defense
		else {
			return damage - defense;
		}

	}

	public bool RunSuccess (float monsterSpeed){
		//Create monster speed (Subtract 10 from the strength and then square it. For my intents, this will cause weaker monsters to be faster.
		//int monsterSpeed = (monsterStrength - 10) * (monsterStrength - 10);
		if ((speed) > monsterSpeed)
			return true;
		else
			return false;
	}

	public bool CharmSuccess (int monsterBrains, int monsterCharisma){
		//Checks intelligence and charisma against monster intelligence/charisma
		if ((charisma + intelligence) > (monsterBrains + monsterCharisma))
			return true;
		else
			return false;
	}

	//powerup for picking up sword
	public void PickupSword(){
		//Adds to player strength
		strength += 5;
	}

	//powerup for picking up shield
	public void PickupShield(){
		//Adds to player defense
		defense += 5;
	}

	//powerup for picking up potion
	public void PickupPotion(){
		//Adds to player speed
		speed += 5;
	}
}
[System.Serializable]
public class Monster
{
	public string monsterName;
	public int health;
	public int strength;
	public int dexterity;
	public int speed;
	public int charisma;
	public int intelligence;

	public void Spawn (string _n){
		monsterName = _n;
	}

	public void Initialize (int _s, int _d, int _c, int _i)
	{
		
		strength = _s;
		dexterity = _d;
		speed = ((_d - _s) * (_d - _s));
		charisma = _c;
		intelligence = _i;
		if (speed == 0) {
			speed++;
		}
	}
}
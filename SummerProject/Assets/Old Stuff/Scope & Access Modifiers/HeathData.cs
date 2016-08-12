[System.Serializable]
public class HealthData
{
	public int Strength;
	public int Health; 
	public string username;
	private int defense = 100;


	public int TakeDownDefense(){
		return defense -= 10;
	}

}


/*
 * 
 * 
 * 
 * void move()
 * pos.x=Input.GetAxis("Horizontal")*Time.deltaTime*speed;
 * transform.Translate(pos);
 * 
 * 
 * 
 * 
 * /*
 */

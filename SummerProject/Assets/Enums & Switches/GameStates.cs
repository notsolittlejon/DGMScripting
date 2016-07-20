public class GameStates{

	//This will change the mode the game is playing in
	public enum States {Loading, Starting, Playing, Ending};
	//Used to change states in other scripts
	public static States currentGameState = States.Loading;

}

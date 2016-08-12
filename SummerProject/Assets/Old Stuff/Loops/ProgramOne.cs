using UnityEngine;
using System.Collections;

public class ProgramOne : MonoBehaviour {

	public enum myOperations {ADD, SUBTRACT, MULTIPLY, DIVIDE, SQUARE };

	public myOperations currentOperation;

	int ChangeOperation(int _a, int _b){
		int value = 0;
		switch(currentOperation){
		case myOperations.ADD:
			value = _a+_b;
			break;
		case myOperations.SUBTRACT:
			value = _a-_b;
			break;
		case myOperations.MULTIPLY:
			value = _a*_b;
			break;
		case myOperations.DIVIDE:
			value = _a/_b;
			break;
		case myOperations.SQUARE:
			value = (_a+_b)*(_a+_b);
			break;	
		}
		return value;	
	}
	//Function for when mouse is clicked
	void OnMouseDown(){
		int finalValue = ChangeOperation(1,1);
		print (finalValue);
	}
}
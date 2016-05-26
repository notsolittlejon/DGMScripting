using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour{
	//------------------------------------------------------------
	int myInt;
	float myFloat;
	string myString;

	//-------------------------------------------------------------
	string MyString (string _a, string _b)
	{
		return _a + _b;
	}

	float MyFloat(float _a, float _b){
		return _a * _b;
	}
	int MyInt(int _i, int _j){
		return _i+_j;
	}

	/*Lorem ipsum dolor sit amet, id sea lorem nemore, eos te novum meliore, est an eius ponderum interesset. Erat quando corrumpit an duo. In pro autem antiopam, noluisse referrentur has ei, at cum illum doctus pericula. Nam at euismod nusquam. Pri at primis graeci, an semper assueverit cum. Errem habemus mel ad, saepe iriure duo ut, pri ad stet aliquid.

	Ea legimus praesent euripidis cum, atqui solet delenit est an. Cu omittam nominati voluptatum sed, no pro prima paulo aeterno. Ut est oporteat pertinax intellegam. Nominavi laboramus ei his.

	Eu per atqui inimicus. Vide natum id sed, duo ut natum tollit abhorreant, malorum evertitur eum et. Ad eam natum dicant legere, at duo rebum zril, id omittam officiis erroribus usu. Copiosae dissentiunt mei ne, sit partem vidisse an. At quo omnium invidunt, vim ne cibo prompta officiis. Est possim invenire elaboraret ex, at wisi scaevola nam. Ne eos duis qualisque interpretaris.

	Nam consulatu prodesset ut, ei assum noluisse reformidans mei, vim at falli interesset liberavisse. Cu mel sanctus efficiendi, elit adipisci periculis ei usu. Sit dicta facete prompta ad, etiam eripuit iracundia per ad, has duis prompta eu. Rebum nobis consequat ius cu, an est explicari laboramus, cum te modo suscipiantur. Mei ne mazim atomorum, dico mazim accusam an vix. In mea illum ullamcorper, alii autem sententiae vis id, duo alii justo definiebas eu.

	No velit iudicabit deseruisse pri. His ea nobis eruditi, sea te corpora principes. Mei cu graeco rationibus scribentur. Idque possit at mel, has at solum falli.
	*/
	//-----------------------------------------------------------
	void Start (){
		myInt = MyInt (10,4);
		myFloat = MyFloat (1.337f, 0.968f);
		myString = MyString ("Hey there, ", "isn't C# lovely?");
		print (myInt);
		print (myFloat);
		print (myString);
	}


}
using UnityEngine;
using System.Collections;

public class Gui_Text : MonoBehaviour {

	float Timer = 0.0f;

	private void OnGUI(){
		Timer += Time.deltaTime;
		string timer = Timer.ToString();

		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Munro",typeof(Font));
		myStyle.font = myFont;
		GUI.contentColor = Color.black;
		//GUI.Label(new Rect(Screen.width/2,Screen.height/2+30,75,50),timer,myStyle);
		if (Timer < 5){
			GUI.Label(new Rect(Screen.width/2 - 200,Screen.height/2,75,50),"Hi, I'm Damien.",myStyle);
		}
		if (Timer >=5 && Timer < 10){
			GUI.Label(new Rect(Screen.width/2 - 200,Screen.height/2,75,50),"Use A and D to move left or right.",myStyle);
		}
		if (Timer >=10 && Timer < 15){
			GUI.Label(new Rect(Screen.width/2 - 200,Screen.height/2,75,50),"Press Space to jump.",myStyle);
		}
		if (Timer >=15 && Timer < 20){
			GUI.Label(new Rect(Screen.width/2 - 200,Screen.height/2,75,50),"E to interact with objects.",myStyle);
		}
		if (Timer >=20 && Timer < 33){
			GUI.Label(new Rect(Screen.width/2 - 200,Screen.height/2,75,50),"You got it! Feel free to move around. Good luck!",myStyle);
		}
	
	}
}

using UnityEngine;
using System.Collections;

public class Gui_Text : MonoBehaviour {

	private void OnGUI(){
		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Munro",typeof(Font));
		myStyle.font = myFont;
		GUI.contentColor = Color.black;
		GUI.Label(new Rect(Screen.width/2,Screen.height/2,75,50),"Hi, I'm Damien.",myStyle);
	
	}
}

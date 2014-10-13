using UnityEngine;
using System.Collections;

public class BoxTrigger : MonoBehaviour {
	bool showGui = false;
	bool inTrigger = false;
	bool buttonPress = false;

	void Update(){
		if (inTrigger){
			if (Input.GetKeyDown(KeyCode.E)){
				buttonPress = true;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D e){
		inTrigger = true;
		if (e.gameObject.tag == "Player"){
			showGui = true;
		}
	}

	void OnTriggerExit2D(Collider2D e){
		inTrigger = false;
		if (e.gameObject.tag == "Player"){
			showGui = false;
			buttonPress = false;
		}
	}

	void OnGUI(){
		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Munro",typeof(Font));
		myStyle.font = myFont;
		GUI.contentColor = Color.black;

		if(showGui == true){
			GUI.Label(new Rect(Screen.width/2+50,Screen.height/2+50,75,50),"You're by the box. Press E for super geeky stuff.",myStyle);
		}
		if(buttonPress == true){
			GUI.Label(new Rect(Screen.width/2+200,Screen.height/2,100,50),"SUPER GEEKY STUFF. RAWR.",myStyle);
		}
	}

}

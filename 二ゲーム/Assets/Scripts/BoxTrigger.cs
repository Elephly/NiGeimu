using UnityEngine;
using System.Collections;

public class BoxTrigger : MonoBehaviour {
	bool showGui = false;
	bool inTrigger = false;
	bool buttonPress = false;
	bool doneOnce = false; 
	float randStuff = 1f;


	void Update(){
		if (inTrigger){
			Interact();
		}
	}

	void Interact(){
		if (Input.GetKey(KeyCode.E)){
			buttonPress = true;
			if (randStuff > 0 && Input.GetKey(KeyCode.Q)){
				randStuff--;
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
		string rand = randStuff.ToString();
		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Munro",typeof(Font));
		myStyle.font = myFont;
		GUI.contentColor = Color.black;
		GUI.Label(new Rect(Screen.width/2-100,Screen.height/2-100,75,50),"Items in the box: " + rand,myStyle);

		if(showGui == true){
			GUI.Label(new Rect(Screen.width/2+50,Screen.height/2+50,75,50),"You're by the box. Press E for super geeky stuff.",myStyle);
		}
		if(buttonPress){
			if (doneOnce == false){
				GUI.Label(new Rect(Screen.width/2+200,Screen.height/2,100,50),"SUPER GEEKY STUFF. RAWR.",myStyle);
			}
			else if (doneOnce == true){
				GUI.Label(new Rect(Screen.width/2+200,Screen.height/2+20,100,50),"YOU'VE ALREADY DONE THIS, ASSHOLE.",myStyle);
			}
		}
	}

}

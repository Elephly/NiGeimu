using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	float speed = 8f;
	float jumpSpeed = 15f;

	bool grounded = true;

	void Update () {
		Movement();
	}

	void Movement () {
		if (grounded){
			if (Input.GetKey(KeyCode.D)){
				transform.Translate (Vector2.right * speed *Time.deltaTime);
				transform.eulerAngles = new Vector2(0,0);
			}
			if (Input.GetKey(KeyCode.A)){
				transform.Translate (Vector2.right * speed *Time.deltaTime);
				transform.eulerAngles = new Vector2(0,180);
			
			}

			if (Input.GetKey(KeyCode.Space)){
				rigidbody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);

			}
		}

	}
}

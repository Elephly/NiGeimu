﻿using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	public static bool facingRight = true;

	float speed = 8f;
	float jumpSpeed = 500f;

	bool canJump;
	bool isJumping;
	
	void Update () {
		Movement();
	}

	void Movement () {

		if (Input.GetKey(KeyCode.D)){
			transform.Translate (Vector2.right * speed *Time.deltaTime);
			transform.eulerAngles = new Vector2(0,0);
			facingRight = true;
		}
		if (Input.GetKey(KeyCode.A)){
			transform.Translate (Vector2.right * speed *Time.deltaTime);
			transform.eulerAngles = new Vector2(0,180);
			facingRight = false;
		}
		if (canJump && Input.GetKeyDown(KeyCode.Space)){
			rigidbody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);
			canJump = false;
			isJumping = true;
		}
		if (canJump && Input.GetKeyDown(KeyCode.Space)){
			rigidbody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Force);

			canJump = false;
			isJumping = true;
		}
	}


	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground"){
			canJump = true;
			isJumping = false;
		}
	}

}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour {
	float speed;

	// Use this for initialization
	void Start () {
		speed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		//Get the enemy current user
		Vector2 position = transform.position;

		//Compute the enemy new position
		position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

		//Update the enemy position
		transform.position = position;

		//this is the bottom-left point of the screen
		Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

		//if the enemy went outside the screen on the bottom, then destroy the enemy
		if (transform.position.y < min.y) {
			Destroy (gameObject);
		}
	}
}

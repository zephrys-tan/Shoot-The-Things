using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour {
	static bool delete;

	// Use this for initialization
	void Start () {
		delete = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		// Create random variable
		float xPos = Random.Range (-7, 7);
		float yVel = Random.Range (9, 14);
		float xVel = Random.Range (-4, 4);

		// Move object somewhere on the x-axis
		if (this.transform.position.y < -6 && delete==false) {
			xPos = Random.Range (-7, 7);

			if (xPos < -3)
				xVel = Random.Range (-1, 6);
			else if (xPos > 3)
				xVel = Random.Range (-6, 1);

			this.transform.position = new Vector2 (xPos, -6);

			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (xVel, yVel);
			// this.transform.eulerAngles = new Vector3(0, 0, 45);
			this.GetComponent<Rigidbody2D> ().AddTorque (15);
			delete = true;
		} else if (this.transform.position.y < -6 && delete==true) {
			Destroy (gameObject);
			GameObject.Find ("Player").GetComponent<Player> ().getDamaged ();

		}

		// Throw object upwards 

		// Reset once at bottom

	}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0)) 
		{
			//player.GetComponent<Player> ().getHealed ();
			Destroy (gameObject);
		} 
	}
}

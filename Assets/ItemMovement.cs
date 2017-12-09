using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour {
	bool isMoving = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float yPos = Random.Range (0, 4);

		if (this.transform.position.x > 9 && isMoving==false) {
			yPos = Random.Range (0, 4);

			this.transform.position = new Vector2 (-9, yPos);

			this.GetComponent<Rigidbody2D> ().velocity = new Vector2 (10, 0);
			// this.transform.eulerAngles = new Vector3(0, 0, 45);
			this.GetComponent<Rigidbody2D> ().AddTorque (15);
			isMoving = true;
		} else if (this.transform.position.x > 9 && isMoving==true) {
			Destroy (gameObject);
			//GameObject.Find ("Player").GetComponent<Player> ().getAmmo ();
			//isMoving = false;
		}
	}

	void OnMouseDown()
	{
		GameObject.Find ("Player").GetComponent<Player> ().getAmmo ();
	}

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0)) 
		{
			//player.GetComponent<Player> ().getHealed ();
			Destroy (gameObject);
		} 
	}
}

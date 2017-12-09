using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossheir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = this.GetComponent<Camera> ().ScreenToWorldPoint (Input.mousePosition);
		var target = GameObject.Find ("Cursor");

		target.transform.position = new Vector3 (pos.x, pos.y, -9);

		Cursor.visible = false;
	}
}

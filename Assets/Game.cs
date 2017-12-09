using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
	static float timer = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Part 1

		timer = timer + Time.deltaTime;

		//if (timer >= 2f && timer <= 2.4f) {
		//	GameObject.Find ("Enemy_0").transform.position = new Vector3(0, -3, 0);
		//	GameObject.Find ("Enemy_0").GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 5);
		//}
	}
}

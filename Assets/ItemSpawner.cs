using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {
	public GameObject Item;

	float maxSpawnRateInSeconds = 10f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", maxSpawnRateInSeconds);

		InvokeRepeating ("IncreaseSpawnRate", 0f, 30f);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) 
		{
			var items = GameObject.FindGameObjectsWithTag("Item");
			foreach(var item in items)
			{
				Destroy(item);
				GameObject.Find ("Player").GetComponent<Player> ().getAmmo ();
			}
		}
		//if(Input.GetMouseButtonDown(0)) GameObject.Find ("Player").GetComponent<Player> ().doShoot ();
	}

	void SpawnEnemy() 
	{
		GameObject anEnemy = (GameObject)Instantiate (Item);
		anEnemy.transform.position = new Vector2 (10, 0);
		ScheduleNextEnemySpawn ();
	}

	void ScheduleNextEnemySpawn()
	{
		float spawnInNSeconds;

		if (maxSpawnRateInSeconds > 1f) {
			spawnInNSeconds = 7f;
		} 
		else
			spawnInNSeconds = 1f;

		Invoke ("SpawnEnemy", spawnInNSeconds);
	}

	void IncreaseSpawnRate()
	{
		if (maxSpawnRateInSeconds > 1f)
			maxSpawnRateInSeconds--;
		if (maxSpawnRateInSeconds == 1f)
			CancelInvoke ("IncreaseSpawnRate");
	}
}

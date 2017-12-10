﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public GameObject Enemy;
	public GameObject Explosion;

	float maxSpawnRateInSeconds = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("SpawnEnemy", maxSpawnRateInSeconds);

		InvokeRepeating ("IncreaseSpawnRate", 0f, 30f);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) GameObject.Find ("Player").GetComponent<Player> ().doShoot ();
		if (Input.GetMouseButtonDown (1)) 
		{
			var enemys = GameObject.FindGameObjectsWithTag("Enemy");
			foreach(var enemy in enemys)
			{
				Destroy(enemy);
				GameObject explosion = (GameObject)Instantiate (Explosion);
				explosion.transform.position = enemy.transform.position;
			}
		}
	}

	void SpawnEnemy() 
	{
		GameObject anEnemy = (GameObject)Instantiate (Enemy);
		anEnemy.transform.position = new Vector2 (0, -6);
		ScheduleNextEnemySpawn ();
	}

	void ScheduleNextEnemySpawn()
	{
		float spawnInNSeconds;

		if (maxSpawnRateInSeconds > 1f) {
			spawnInNSeconds = Random.Range (1f, maxSpawnRateInSeconds);
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

	void Explode()
	{
		
	}
}

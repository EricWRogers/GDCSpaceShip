using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	ObjectPool pool;
	public int maxEnemies = 5;
	public int currentEnemies = 0;
	public int spawnDelay = 30;
	int spawnTimer = 0;
	public float spawnRange = 15f;

	void Start () {
		pool = GetComponent<ObjectPool>();
	}

	void Update () {
		if (currentEnemies < maxEnemies) {
			spawnTimer++;
		}
		if (spawnTimer == spawnDelay) {
			spawnTimer = 0;
			GameObject enemy = pool.GetFromPool();
			if (enemy) {
				currentEnemies++; 

				//Decide where to put the enemy
				Quaternion spawnRot = Quaternion.Euler(new Vector3(
				Random.Range(-179, 180),Random.Range(-179, 180),Random.Range(-179, 180))); //We want to spawn the enemies at the same distance around the planet, but at different locations
				//spawnRot was only spawning in a particular quadrant of the map, so we'll randomly make the x y and z values negative
				int swapX = Random.Range(1,3);
				if (swapX == 2) swapX = -1;
				int swapY = Random.Range(1,3);
				if (swapY == 2) swapY = -1;
				int swapZ = Random.Range(1,3);
				if (swapZ == 2) swapZ = -1;
				enemy.transform.position = spawnRot.eulerAngles.normalized * spawnRange; //We apply the angles and the distance we want
				enemy.transform.position = new Vector3(enemy.transform.position.x * swapX, enemy.transform.position.y * swapY, enemy.transform.position.z * swapZ); //And the inverting of coordinates that we got randomly

				//Set up what we need for the enemy here
				enemy.transform.LookAt(Vector3.zero);
				Enemy eStats = enemy.GetComponent<Enemy>();
				eStats.isAlive = true;
				eStats.health = eStats.maxHealth;
				Rigidbody eRB = enemy.GetComponent<Rigidbody>(); //We don't want the enemy to start off moving
				eRB.velocity = Vector3.zero;
				eRB.angularVelocity = Vector3.zero;
				TrailRenderer tr = enemy.GetComponentInChildren<TrailRenderer>();
				tr.Clear();

				enemy.SetActive(true);


			} else {
				maxEnemies = currentEnemies;
			}
		}
	}
}

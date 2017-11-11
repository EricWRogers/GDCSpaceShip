using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {

	//Enemy
	public GameObject Enemy;
	public int numOfEnemies;
	//Array of Enemy Spawners
	public GameObject[] eSpawners;

	// Use this for initialization
	void Start () {
		AutoFindSpawns ();
		SpawnEnemy ();
	}
	
	// Update is called once per frame
	void Update () {
		if(numOfEnemies <= 0)
		{
			SpawnEnemy();
		}
	}

	//Find All Spawners in level
	void AutoFindSpawns()
	{
		//eSpawners = GameObject.FindGameObjectsWithTag("Spawners");
	}
	//spawnEnemys it takes the level and give the enemies random stats based on the level number
	void SpawnEnemy()
	{  
		foreach (GameObject respawn in eSpawners)
		{
			Instantiate(Enemy, respawn.transform.position, respawn.transform.rotation);
			numOfEnemies++;
		}
	}

}
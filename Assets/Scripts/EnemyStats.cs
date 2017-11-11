using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

	public int health = 100;
	public int maxHealth = 100;
	public bool isAlive = false;

	EnemySpawner manager;

	void Start () {
		manager = GameObject.FindGameObjectWithTag("Enemy Manager").GetComponent<EnemySpawner>();
	}

	void Update () {
		if (health == 0 ) {
			isAlive = false;
		}
		if (!isAlive) {
			manager.currentEnemies--;
			gameObject.SetActive(false);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;
	public int maxHealth = 100;
	public bool isAlive = false;

	EnemySpawner manager;
	ObjectPool pickups;

	void Start () {
		manager = GameObject.FindGameObjectWithTag("Enemy Manager").GetComponent<EnemySpawner>();
		pickups = GameObject.Find("Pickup Pool").GetComponent<ObjectPool>();
	}

	public void Damage(int dmg) {
		health -= dmg;
	}

	void Update () {
		if (health <= 0 ) {
			isAlive = false;
		}
		if (!isAlive) {
			manager.currentEnemies--;
			GameObject pickup = pickups.GetFromPool();
			pickup.SetActive(true);
			pickup.GetComponent<Pickup>().RestartTimer();
			gameObject.SetActive(false);
			pickup.transform.position = transform.position;
		}
	}
}

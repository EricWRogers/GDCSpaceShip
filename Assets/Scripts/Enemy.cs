using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;
	public int maxHealth = 100;
	public bool isAlive = false;

	EnemySpawner manager;
	ObjectPool pickups;

	bool damageCausedByPlayer = false;

	void Start () {
		manager = GameObject.FindGameObjectWithTag("Enemy Manager").GetComponent<EnemySpawner>();
		pickups = GameObject.Find("Pickup Pool").GetComponent<ObjectPool>();
	}

	public void Damage(int dmg, bool plr) {
		damageCausedByPlayer = plr;
		health -= dmg;
	}

	void Update () {
		if (health <= 0 ) {
			isAlive = false;
		}
		if (!isAlive) {
			if (damageCausedByPlayer) {
				GameObject pickup = pickups.GetFromPool();
				pickup.SetActive(true);
				pickup.GetComponent<Pickup>().RestartTimer();
				pickup.transform.position = transform.position;
			}
			manager.currentEnemies--;
			TrailRenderer tr = gameObject.GetComponentInChildren<TrailRenderer>();
			tr.Clear();
			gameObject.SetActive(false);
		}
	}
}

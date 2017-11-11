using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth = 100;
	int health;
	public bool isAlive = false;

	void Start () {
		health = maxHealth;
		isAlive = true;
	}
	
	void Damage(int dmg) {
		health -= dmg;
		if (isAlive && health <= 0) {
			Die();
		}
	}

	void Die() {
		//Handle whatever we want to do when the player dies
	}
}

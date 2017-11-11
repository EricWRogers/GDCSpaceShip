using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int maxHealth = 100;
	public int health;
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

	//Remove this if we don't need it later
	void Update() {
		if (health == 0 && isAlive) {
			Damage(0);
		}
	}

	void Die() {
		isAlive = false;
		gameObject.GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(Random.Range(-10, 10)*10,Random.Range(-10, 10)*10,Random.Range(-10, 10)*10), ForceMode.Impulse);
		gameObject.GetComponent<Rigidbody>().AddForce((transform.forward * Random.Range(.1f,1f)) + (transform.up * Random.Range(-1f,1f)) + (transform.right * Random.Range(-1f,1f)), ForceMode.Impulse);
		gameObject.GetComponentInChildren<Camera>().transform.parent = transform.parent;
		//Handle whatever we want to do when the player dies
	}
}

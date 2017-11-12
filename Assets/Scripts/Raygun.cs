using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raygun : MonoBehaviour {

	public int dmg = 1;
	ParticleSystem prt;
	ParticleSystem.EmissionModule em;

	void Start () {
		prt = gameObject.GetComponent<ParticleSystem>();
		em = prt.emission;
	}

	void Update () {
		em.enabled = false;
		if (Input.GetAxis("Fire1") > 0) {
			em.enabled = true;
		} 
	}

	void OnParticleCollision(GameObject other)
    {
    	Enemy e = other.GetComponent<Enemy>();
    	if (e) {
    		e.Damage(dmg, true);
    	}
    }
}

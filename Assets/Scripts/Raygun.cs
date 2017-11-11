using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raygun : MonoBehaviour {

	public int dmg = 0;
	ParticleSystem.EmissionModule em;

	void Start () {
		em = gameObject.GetComponent<ParticleSystem>().emission;
	}

	void Update () {
		em.enabled = false;
		if (Input.GetAxis("Fire1") > 0) {
			em.enabled = true;
		} 
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFol : MonoBehaviour {
	public GameObject plant = null;
	public Transform target = null;

	public float thrust;
	public Rigidbody rb;

	void Start () {
		findPlant();
		rb = GetComponent<Rigidbody>();
	}

	private void findPlant(){
		plant = GameObject.FindGameObjectWithTag("Plant");
		target = plant.transform;
	}

	void Update () {
		transform.LookAt (target);
	}

	void FixedUpdate()
	{
		rb.AddForce(transform.forward * thrust);
	}
}

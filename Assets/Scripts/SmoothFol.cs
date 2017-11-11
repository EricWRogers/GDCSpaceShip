using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFol : MonoBehaviour {
	public GameObject plant = null;
	public Transform target = null;

	public float thrust;
	public Rigidbody rb;

	//private GameLoop gameloop = GameObject.Find("GM").GetComponent <GameLoop> ();
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

	void OnTriggerEnter (Collider collision)
	{
		// Put a particle effect here
		if(collision.gameObject.tag == "Plant")
		{
			GetComponent<Enemy>().health=0;
		}

	}
}

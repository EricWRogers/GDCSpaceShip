/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour {
	public GameObject plant;
	public Transform target = null;

	public float speed = 5f;
	public float rotateSpeed = 200f;

	private Rigidbody2D rb;
	//private GameLoop gameloop = GameObject.Find("GM").GetComponent <GameLoop> ();
	// Use this for initialization
	void Start () {
		findPlayer();
		rb = GetComponent<Rigidbody2D>();
	}
	IEnumerator MyCoroutine()
    {
            yield return new WaitForSeconds(.5f);
            findPlayer();
    }
	private void findPlayer(){
        plant = GameObject.FindGameObjectWithTag("Plant");
		target = player.transform;
    }
	void FixedUpdate () {
		Vector2 direction = (Vector2)target.position - rb.position;

		direction.Normalize();

		float rotateAmount = Vector3.Cross(direction, transform.up).z;

		rb.angularVelocity = -rotateAmount * rotateSpeed;

		rb.velocity = transform.up * speed;


	}
	
	void OnTriggerEnter2D (Collider2D collision)
	{
		// Put a particle effect here
		if(collision.gameObject.tag == "Plant")
		{
			//gameloop.Magic++;
			//collision.GetComponent<PlayerHealthandSave>().manaUp();
			Destroy(gameObject);
		}
			
	}
}*/
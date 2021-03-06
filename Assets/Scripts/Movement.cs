﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	Rigidbody rb;

	public float minAccel = -1f;
	public float maxAccel = 5f;
	public float accelRate = 2f;
	public float accel;

	public bool move = true;

	Vector2 screenCenter;
	float maxSDisp;

	public float maxSpeed = 10f;
	public float maxRotSpeed = 15f;

	public GameObject holder;

	PlayerHealth health;

	void Start () {
		Cursor.lockState = CursorLockMode.Confined;
		rb = gameObject.GetComponent<Rigidbody>();
		screenCenter = new Vector2(Screen.width/2, Screen.height/2);
		if (Screen.width > Screen.height) { maxSDisp = Screen.height/2; } else { maxSDisp = Screen.width/2; }
		health = gameObject.GetComponent<PlayerHealth>();
	}

	void FixedUpdate () {
		if (health.isAlive) {
		// Pitch/roll/yaw rotation
		float angle = Mathf.Atan2(screenCenter.y-Input.mousePosition.y,screenCenter.x-Input.mousePosition.x);
		float disp = Vector2.Distance(screenCenter, new Vector2(Input.mousePosition.x, Input.mousePosition.y));
		if (move) {
			float rotSpeed = maxRotSpeed*(Vector2.Distance(screenCenter, new Vector2(Input.mousePosition.x, Input.mousePosition.y))/maxSDisp);
			Vector3 desRot = new Vector3(rotSpeed*Mathf.Sin(angle), -rotSpeed*Mathf.Cos(angle),0);
			rb.angularVelocity = Vector3.zero;
			rb.AddRelativeTorque(desRot);
			rb.angularVelocity = new Vector3(rb.angularVelocity.normalized.x, rb.angularVelocity.normalized.y, 0) * Mathf.Lerp(0, maxRotSpeed, disp) + new Vector3(0,0,Input.GetAxis("Horizontal"));
			holder.transform.localRotation = Quaternion.Euler(new Vector3(0,0,0));
		} else {
			float rotSpeed = maxRotSpeed*(Vector2.Distance(screenCenter, new Vector2(Input.mousePosition.x, Input.mousePosition.y))/maxSDisp);
			Vector3 desRot = new Vector3(rotSpeed*Mathf.Sin(angle), -rotSpeed*Mathf.Cos(angle),0);
			holder.transform.localRotation = Quaternion.Slerp(holder.transform.localRotation, Quaternion.Euler(desRot), maxRotSpeed * Time.deltaTime);
			rb.angularVelocity = new Vector3(0,0,Input.GetAxis("Horizontal"));
		}
		if (Input.GetKeyDown("space")) {
			move = !move;
		}
		// Forward/reverse thrust
		accel += Input.GetAxis("Vertical") * accelRate;
		accel = Mathf.Clamp(accel, minAccel, maxAccel);
		Vector3 force = transform.forward * accel;
		rb.AddForce(force);
		rb.velocity = transform.forward * Mathf.Clamp(rb.velocity.magnitude, 0, maxSpeed);
		}

	}
}
 
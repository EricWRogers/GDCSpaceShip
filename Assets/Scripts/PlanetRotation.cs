using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

	public float rotateSpeed = 1f;
	
	void Update () {
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0,0,rotateSpeed));
	}
}

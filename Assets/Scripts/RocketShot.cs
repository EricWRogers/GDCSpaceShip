using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShot : MonoBehaviour {

	public int cd = 180;
	int cdI = 0;
	public GameObject rocket;

	void Update () {
		if (cdI > 0) cdI--;
		if (cdI == 0 && Input.GetAxis("Fire2") > 0) {
			cdI = cd;
			GameObject nr = Instantiate(rocket);
			nr.transform.position = transform.position + transform.forward;
			nr.transform.rotation = transform.rotation;
		}
	}

}

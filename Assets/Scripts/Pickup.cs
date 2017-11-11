using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	int timer;
	public int dur = 10;

	public void RestartTimer() {timer = 0;}

	void Update () {
		timer++;
		if (timer == dur*60) {
			gameObject.SetActive(false);
		}
	}
}

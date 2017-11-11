using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	int timer;
	public int duration = 10;

	public void RestartTimer() {timer = 0;}

	void Update () {
		timer++;
		if (timer == duration*60) {
			gameObject.SetActive(false);
		}
	}
}

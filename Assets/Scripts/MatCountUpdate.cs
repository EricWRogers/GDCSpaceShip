using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatCountUpdate : MonoBehaviour {



	public int material;

	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		material++;
		HUD.instance.Material.text = material.ToString ();

	}
}

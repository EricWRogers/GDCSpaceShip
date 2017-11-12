using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : PlayerHealth {
	public Text Score;
	public Text Health;
	public Text Material;
	EnemySpawner manager;
	PlayerHealth pStats;
	public static HUD instance;
	int score = 0;
	int numEnemies = 0;
	bool Badwolf = false, Trouble = true;


	// Use this for initialization

	void Awake(){
		instance = this;
	}

	void Start () {
		Score.text = score.ToString();
		Health.text = health.ToString ();
		manager = GameObject.FindGameObjectWithTag("Enemy Manager").GetComponent<EnemySpawner>();
		numEnemies = manager.maxEnemies;
	}
	
	// Update is called once per frame
	void Update () {
		Health.text = health.ToString ();
		
		if (manager.currentEnemies != manager.maxEnemies && Trouble == true) {
			Badwolf = false;
		} else {
			Trouble = false;
			Badwolf = true;
		}

		//Update Score
		if (Badwolf) {
			if (numEnemies != manager.currentEnemies) {
				score += 50;
				Score.text = score.ToString ();
			}
		}
			
	}
}

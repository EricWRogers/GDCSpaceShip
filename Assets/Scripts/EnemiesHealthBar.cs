using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHealthBar : MonoBehaviour {
    GameObject bar;
    Enemy enemy;
	// Use this for initialization
	void Start () {
        enemy = GameObject.Find("EnemyShip").GetComponent<Enemy>();
       
	}
    void FixedUpdate()
    {
        bar.transform.localScale = new Vector3(Mathf.Clamp(((float)enemy.health / (float)enemy.maxHealth),
                                                           0f, 1f), bar.transform.localScale.y,
                                                     bar.transform.localScale.z);
    }

    // Update is called once per frame
    void Update () {
        bar = GameObject.FindGameObjectWithTag("EnemyHealthBar");

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesHealthBar : MonoBehaviour
{
    public Image bar;
    //Enemy enemy;
    // Use this for initialization
    void Start()
    {
        //enemy = GameObject.Find("EnemyShip").GetComponent<Enemy>();

    }
    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = (float)GetComponent<Enemy>().health / (float)GetComponent<Enemy>().maxHealth;
    }
}


﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingWF : MonoBehaviour
{
    //public int damage = 1;
    public float speed = 15;
    public Rigidbody2D rb;
   // GameObject enemy;
    //takeDamage takeDmg;

    //void Awake()
    //{
    //    enemy = GameObject.FindGameObjectWithTag("Enemy");
    //    takeDmg = enemy.GetComponent<takeDamage>();
    //}

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.tag == "Enemy" && takeDmg.health > 0)
    //    {
    //        takeDmg.takeDamagef(damage);
    //    }
    //}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtEnemy : MonoBehaviour
{
    public int damage;
    GameObject enemy;
    takeDamage takeDmg;

    void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        takeDmg = enemy.GetComponent<takeDamage>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy" && takeDmg.health > 0)
        {
            takeDmg.takeDamagef(damage);
        }
    }
}

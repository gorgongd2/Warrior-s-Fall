using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtEnemy : MonoBehaviour
{
    public int damage;
    //GameObject enemy;
    //takeDamage takeDmg;

    void Awake()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject collider = col.gameObject;
        takeDamage takeDmg = collider.GetComponent<takeDamage>();
        if (/*col.tag == "Enemy"*/takeDmg)
        {
            //GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
            //takeDmg = enemy.GetComponent<takeDamage>();
            //collider.getComponent<takeDamage>().takeDamagef(damage);
            //takeDmg.takeDamagef(damage);
            takeDmg.takeDamagef(damage);
        }
    }
}

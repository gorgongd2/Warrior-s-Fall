using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtPlayer : MonoBehaviour
{
    public int damage = 1;
    GameObject player;
    takeDamage takeDmg;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        takeDmg = player.GetComponent<takeDamage>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player" && takeDmg.health > 0)
        {
            takeDmg.takeDamagef(damage);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{
    //public int damage = 1;
    public float speed = 15;
    public Rigidbody2D rb;
   // GameObject player;
    //takeDamage takeDmg;

    //void Awake()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    takeDmg = player.GetComponent<takeDamage>();
    //}

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.tag == "Player" && takeDmg.health > 0)
    //    {
    //        takeDmg.takeDamagef(damage);
    //    }
    //}
}

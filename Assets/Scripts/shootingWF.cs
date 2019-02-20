using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingWF : MonoBehaviour
{
    public int damage = 1;
    public float speed = 15;
    public Rigidbody2D rb;
    GameObject LostSoul;
    collisionLostSoulWF enemyHealth;

    void Awake()
    {
        LostSoul = GameObject.FindGameObjectWithTag("Enemy");
        enemyHealth = LostSoul.GetComponent<collisionLostSoulWF>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy" && enemyHealth.enemyHealth > 0)
        {
            enemyHealth.takeDamage(damage);
        }
    }
}

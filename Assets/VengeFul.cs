using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VengeFul : MonoBehaviour
{
    public int damage = 1;
    public float speed = 10;
    public Rigidbody2D rb;
    private takeDamage takeDmg;

    void Awake()
    {
        takeDmg = GetComponent<takeDamage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Wall")
        {
            return;
        }

        if (col.tag == "Attack")
        {
            Destroy(col.gameObject);
        }


        if (takeDmg.health < 1 || col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

 }

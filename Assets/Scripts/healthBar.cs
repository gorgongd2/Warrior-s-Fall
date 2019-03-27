using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour
{
    public GameObject player;
    public Sprite health7;
    public Sprite health6;
    public Sprite health5;
    public Sprite health4;
    public Sprite health3;
    public Sprite health2;
    public Sprite health1;
    public Sprite health0;
    private SpriteRenderer renderer;
    private takeDamage takeDmg;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        takeDmg = player.GetComponent<takeDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        if(takeDmg.health == 7)
        {
            renderer.sprite = health7;
        }

        if (takeDmg.health == 6)
        {
            renderer.sprite = health6;
        }

        if (takeDmg.health == 5)
        {
            renderer.sprite = health5;
        }

        if (takeDmg.health == 4)
        {
            renderer.sprite = health4;
        }

        if (takeDmg.health == 3)
        {
            renderer.sprite = health3;
        }

        if (takeDmg.health == 2)
        {
            renderer.sprite = health2;
        }

        if (takeDmg.health == 1)
        {
            renderer.sprite = health1;
        }

        if (takeDmg.health == 0)
        {
            renderer.sprite = health0;
        }
    }
}

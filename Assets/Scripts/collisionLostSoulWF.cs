﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionLostSoulWF : MonoBehaviour
{
    public GameObject bullet;
    public int enemyHealth;
    public Sprite deathSprite;
    public Transform north;
    public Transform northeast;
    public Transform east;
    public Transform southeast;
    public Transform south;
    public Transform southwest;
    public Transform west;
    public Transform northwest;
    private SpriteRenderer renderer;

    void Awake ()
    {
        renderer = GetComponent<SpriteRenderer> ();
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
        if (enemyHealth < 1)
        {
            renderer.sprite = deathSprite;
            StartCoroutine(deathDelay());

            Instantiate(bullet, north.position, north.rotation);
            Instantiate(bullet, northeast.position, northeast.rotation);
            Instantiate(bullet, east.position, east.rotation);
            Instantiate(bullet, southeast.position, southeast.rotation);
            Instantiate(bullet, south.position, south.rotation);
            Instantiate(bullet, southwest.position, southwest.rotation);
            Instantiate(bullet, west.position, west.rotation);
            Instantiate(bullet, northwest.position, northwest.rotation);
            
            Destroy(gameObject);
        }
    }

    IEnumerator deathDelay()
    {
        yield return new WaitForSeconds(5);
    }

    public void takeDamage(int damage)
    {
        enemyHealth = enemyHealth - damage;
    }
}

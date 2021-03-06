﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostSoulSpawaner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSpan;
    public float spwanRate = 3f;
    float nextSpawn = 0.1f;
    public float spawnWidth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spwanRate;
            randX = Random.Range(-spawnWidth, spawnWidth);
            whereToSpan = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpan, Quaternion.identity);
        }
    }
}
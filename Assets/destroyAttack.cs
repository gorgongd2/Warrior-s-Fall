﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAttack : MonoBehaviour
{
    public float timeBeforeDestruction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Time.time > timeBeforeDestruction)
        //{
            Destroy(gameObject, timeBeforeDestruction);
        //}
    }
}

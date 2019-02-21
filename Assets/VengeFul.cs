using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VengeFul : MonoBehaviour
{
    public int damage = 1;
    public float speed = 10;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostSoulMovement : MonoBehaviour
{
    public int moveRange;
    public float speed = 15;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Mathf.Sin(Time.time) / moveRange); 
    }
}

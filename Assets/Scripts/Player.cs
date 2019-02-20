using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 100;
    public int playerhealth;
    private  Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        //float vAxis = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(hAxis, 0, 0) * speed;
        // rb.MovePosition(transfom.position + movement);
        rb.AddForce(movement);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        playerhealth = playerhealth - 1;
        if (col.tag != "Wall")
        {
            Destroy(col.gameObject);
        }
        if (playerhealth < 1)
        {
            Destroy(gameObject);
        }
    }
}


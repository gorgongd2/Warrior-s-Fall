using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public float speed =10;
    private  Rigidbody2D rb;
    private takeDamage takeDmg;


    void Awake()
    {
        takeDmg = GetComponent<takeDamage>();
    }

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
        if (col.tag == "Attack")
        {
            Destroy(col.gameObject);
        }

        if (takeDmg.health < 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(6);
        }
    }

}







using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    public float speed =10;
    public float flashDurationP;
    private  Rigidbody2D rb;
    private takeDamage takeDmg;
    private SpriteRenderer playerColor;
    private Color color;


    void Awake()
    {
        playerColor = GetComponent<SpriteRenderer>();
        takeDmg = GetComponent<takeDamage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        color = playerColor.color;
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
        if (col.tag == "EnemyAttack")
        {
            Destroy(col.gameObject);
            playerColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (col.tag == "Attack")
        {
            Destroy(col.gameObject);
        }

        if (col.tag == "BossAttack")
        {
            playerColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (col.tag == "Enemy")
        {
            playerColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (takeDmg.health < 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(7);
        }

        IEnumerator stopFlash()
        {
            yield return new WaitForSeconds(flashDurationP);
            playerColor.color = color;
        }
    }

}







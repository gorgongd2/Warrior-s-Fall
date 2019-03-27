using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demonspawn : MonoBehaviour
{
    public float position;
    public float speed;
    public GameObject bullet;
    public Transform spawn;
    public float fireRate;
    public float firstAttack;
    public float stayTime;
    public float timeBeforeMove;
    public float horizontalSpeed;
    public float flashDurationD;
    private float nextFire;
    private takeDamage takeDmg;
    private float Starttime;
    private SpriteRenderer demonColor;
    private Color color;
    private float currentPosition;
    private bool movingRight = true;
    private float moveNext;
    private float distance;


    void Awake()
    {
        demonColor = GetComponent<SpriteRenderer>();
        takeDmg = GetComponent<takeDamage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        color = demonColor.color;
        Starttime = Time.timeSinceLevelLoad;
        currentPosition = transform.position.x;
        distance = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {
        float lifeTime = Time.timeSinceLevelLoad - Starttime;
        if (transform.position.y > position)
        {
            transform.Translate(Vector3.up * speed);
        }

        if (movingRight == true && lifeTime > timeBeforeMove && Time.time > moveNext)
        {
            moveRight();
        }

        if (movingRight == false && lifeTime > timeBeforeMove && Time.time > moveNext)
        {
            moveLeft();
        }

        if (lifeTime > firstAttack && Time.time > nextFire + Random.Range(0, 3))
        {
            nextFire = Time.time + fireRate;
            attack();
        }
    }

    void attack()
    {
        Instantiate(bullet, spawn.position, spawn.rotation);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Wall")
        {
            return;
        }

        if (col.gameObject.name == "Boss")
        {
            Destroy(gameObject);
        }

        if (col.tag == "Attack")
        {
            Destroy(col.gameObject);
            demonColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (col.tag == "EnemyAttack")
        {
            Destroy(col.gameObject);
        }

        if (takeDmg.health < 1 || col.tag == "Player")
        {
            Destroy(gameObject);
        }

        IEnumerator stopFlash()
        {
            yield return new WaitForSeconds(flashDurationD);
            demonColor.color = color;
        }
    }

    void moveRight()
    {
        transform.Translate(Vector3.right * horizontalSpeed);

        if (transform.position.x >= currentPosition + distance)
        {
            moveNext = Time.time + stayTime;
            movingRight = false;
            distance = Random.Range(1, 3);
        }

    }

    void moveLeft()
    {
        transform.Translate(Vector3.right * -horizontalSpeed);

        if (transform.position.x <= currentPosition - distance)
        {
            moveNext = Time.time + stayTime;
            movingRight = true;
            distance = Random.Range(1, 3);
        }
    }
}


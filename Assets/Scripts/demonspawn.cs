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
    private float nextFire;
    private takeDamage takeDmg;
    private float Starttime;

    void Awake()
    {
        takeDmg = GetComponent<takeDamage>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Starttime = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        float lifeTime = Time.timeSinceLevelLoad - Starttime;
        if (transform.position.y > position)
        {
            transform.Translate(Vector3.up * speed);
        }

        if(lifeTime > firstAttack && Time.time > nextFire + Random.Range(0,3))
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

        if (col.tag == "Attack")
        {
            Destroy(col.gameObject);
        }

        if (takeDmg.health < 1 || col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}

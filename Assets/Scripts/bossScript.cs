using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript : MonoBehaviour
{
    public float speed;
    public float position;
    public GameObject bossAttack;
    //public GameObject[] attackPosition;
    //public Transform[] attackPosition;
    //public GameObject[] goArray;
    public Transform[] attackPosition;
    //public Transform attackPosition2;
    //std::Array<attackPosition> = [attackPosition1, attackPosition2];

    public int banabas = 1;
    public float bossTime;
    public float attackRate;
    public float flashDurationB;
    private float nextAttack;
    private int nmbr;
    private takeDamage takeDmg;
    private SpriteRenderer bossColor;
    private Color color;
    // Start is called before the first frame update

    void Awake()
    {
        bossColor = GetComponent<SpriteRenderer>();
        takeDmg = GetComponent<takeDamage>();
    }

    void Start()
    {
        color = bossColor.color;
        //number = Random.Range(0, 1);
        /* goArray = GameObject.FindGameObjectsWithTag("bossAttack");
         attackPosition = new Transform[goArray.length];

         for (int i = 0; i < goArray.length; i++)
         {
             attackPosition[i] = goArray[i].transform;
         }*/

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > position && Time.timeSinceLevelLoad > bossTime)
        {
            transform.Translate(Vector3.up * speed);
        }

        if (Time.timeSinceLevelLoad > bossTime + 5 && Time.time > nextAttack)
        {
            attack();
        }
       
    }

    void attack()
    {
        nmbr = Random.Range(0,2);
        nextAttack = Time.time + attackRate;
        //number = Random.Range(0, 1);
        Instantiate(bossAttack, attackPosition[/*Random.Range(0, 1)*/nmbr].position, attackPosition[/*Random.Range(0, 1)*/nmbr].rotation);
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
            bossColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (takeDmg.health < 1 || col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    IEnumerator stopFlash()
    {
        yield return new WaitForSeconds(flashDurationB);
        bossColor.color = color;
    }
}

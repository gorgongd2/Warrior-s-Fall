using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public Slider BossSlider;
    private float nextAttack;
    private int nmbr;
    private takeDamage takeDmg;
    private SpriteRenderer bossColor;
    private Color color;
    private bool activeSlider = false;
    private Vector2 pos1;
    private Vector2 pos2;
    private Animator anim;

    // Start is called before the first frame update

    void Awake()
    {
        bossColor = GetComponent<SpriteRenderer>();
        takeDmg = GetComponent<takeDamage>();
        pos1 = transform.position;
        pos2 = transform.position;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        color = bossColor.color;
        //number = Random.Range(0, 1);
        /* goArray = GameObject.FindGameObjectsWithTag("bossAttack");
         attackPosition = new Transform[goArray.length];

         for (int i = 0; i < goArray.length; i++)
         {
             attackPosition[i] = goArray[i].transform;
         }*/


        pos1.x += 5;
        pos2.x -= 5;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > position && Time.timeSinceLevelLoad > bossTime)
        {
            transform.Translate(Vector3.up * speed);
            if (activeSlider == false)
            {
                BossSlider.gameObject.SetActive(true);
                activeSlider = true;
            }
            pos1.y = transform.position.y;
            pos2.y = transform.position.y;
        }

        if (Time.timeSinceLevelLoad > bossTime + 5 && Time.time > nextAttack)
        {
            StartCoroutine(attack());
        }
       
    }

    IEnumerator attack()
    {
        anim.SetBool("isAttacking", true);
        nmbr = Random.Range(0, 2);
        if (nmbr == 0)
        {
            transform.position = pos1;
        }
        if (nmbr == 1)
        {
            transform.position = pos2;
        }
        nextAttack = Time.time + attackRate;
        yield return new WaitForSeconds(2);


        //number = Random.Range(0, 1);
        Instantiate(bossAttack, attackPosition[/*Random.Range(0, 1)*/nmbr].position, attackPosition[/*Random.Range(0, 1)*/nmbr].rotation);
        anim.SetBool("isAttacking", false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Wall")
        {
            return;
        }

        if (col.tag == "Attack")
        {
            BossSlider.value = takeDmg.health;
            Destroy(col.gameObject);
            bossColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (col.tag == "EnemyAttack")
        {
            Destroy(col.gameObject);
        }

        if (takeDmg.health < 1 || col.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator stopFlash()
    {
        yield return new WaitForSeconds(flashDurationB);
        bossColor.color = color;
    }
}

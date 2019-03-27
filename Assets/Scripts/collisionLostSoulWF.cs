using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionLostSoulWF : MonoBehaviour
{
    public GameObject bullet;
    public Transform north;
    public Transform northeast;
    public Transform east;
    public Transform southeast;
    public Transform south;
    public Transform southwest;
    public Transform west;
    public Transform northwest;
    public float flashDuration;
    //public MeshRenderer soulColor;
    private Color color;
    public Sprite deathSprite;
    //public int damage = 1;
    private takeDamage takeDmg;
    private new SpriteRenderer renderer;

    //death animation setup
    private Animator anim;
    //GameObject player;
    //takeDamage dealDmg;
    private SpriteRenderer soulColor;


    void Awake()
    {
        soulColor = GetComponent<SpriteRenderer>();
        takeDmg = GetComponent<takeDamage>();
        //renderer = GetComponent<SpriteRenderer>();
        //  dealDmg = GameObject.FindGameObjectWithTag("Player").GetComponent<takeDamage>(); 
        //dealDmg =
    }

    private void Start()
    {
        color = soulColor.color;
        anim = GetComponent<Animator>();
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
            soulColor.color = Color.red;
            StartCoroutine(stopFlash());
        }

        if (col.tag == "EnemyAttack")
        {
            Destroy(col.gameObject);
        }

        /* if (col.tag == "Player" && dealDmg.health > 0)
         {
             dealDmg.takeDamagef(damage);
         }*/

        if (takeDmg.health < 1 || col.tag == "Player")
        {
            //renderer.sprite = deathSprite;
            if (anim != null)
            {
                anim.SetBool("isDead", true);
            }
        

            Instantiate(bullet, north.position, north.rotation);
            Instantiate(bullet, northeast.position, northeast.rotation);
            Instantiate(bullet, east.position, east.rotation);
            Instantiate(bullet, southeast.position, southeast.rotation);
            Instantiate(bullet, south.position, south.rotation);
            Instantiate(bullet, southwest.position, southwest.rotation);
            Instantiate(bullet, west.position, west.rotation);
            Instantiate(bullet, northwest.position, northwest.rotation);

            Destroy(gameObject, 1);
        }

        IEnumerator stopFlash()
        {
            yield return new WaitForSeconds(flashDuration);
            soulColor.color = color;
        }
    }
}

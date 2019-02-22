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
    public Sprite deathSprite;
    //public int damage = 1;
    private takeDamage takeDmg;
    private new SpriteRenderer renderer;
    //GameObject player;
    //takeDamage dealDmg;


    void Awake()
    {
        takeDmg = GetComponent<takeDamage>();
        renderer = GetComponent<SpriteRenderer>();
      //  dealDmg = GameObject.FindGameObjectWithTag("Player").GetComponent<takeDamage>(); 
        //dealDmg =
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

       /* if (col.tag == "Player" && dealDmg.health > 0)
        {
            dealDmg.takeDamagef(damage);
        }*/

        if (takeDmg.health < 1 || col.tag == "Player")
        {
            renderer.sprite = deathSprite;

            Instantiate(bullet, north.position, north.rotation);
            Instantiate(bullet, northeast.position, northeast.rotation);
            Instantiate(bullet, east.position, east.rotation);
            Instantiate(bullet, southeast.position, southeast.rotation);
            Instantiate(bullet, south.position, south.rotation);
            Instantiate(bullet, southwest.position, southwest.rotation);
            Instantiate(bullet, west.position, west.rotation);
            Instantiate(bullet, northwest.position, northwest.rotation);

            Destroy(gameObject);
        }
    }
}

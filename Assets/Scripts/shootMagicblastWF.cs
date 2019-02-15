using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootMagicblastWF : MonoBehaviour
{
    public GameObject magicBlast;
    public Transform blastSpawn;
    public float fireRate;
    public int castTime = 5;
    private float nextFire;
    public int MP = 5;
    public int MaxMP = 5;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2") && Time.time > nextFire && MP > 0)
        {
           
            nextFire = Time.time + fireRate;
            StartCoroutine(fire());
            MP--;
        }
    }
    IEnumerator fire()
    {
        yield return new WaitForSeconds(castTime);
        Instantiate(magicBlast, blastSpawn.position, blastSpawn.rotation);

    }
}


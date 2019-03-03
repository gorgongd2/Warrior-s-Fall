using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBulletWF : MonoBehaviour
{
    public GameObject bullet;
    public Transform blastSpawn;
    public float fireRate;
    private float nextFire;
    public bool canFire = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire && canFire || Input.GetKeyDown(KeyCode.O) && Time.time > nextFire && canFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, blastSpawn.position, blastSpawn.rotation);
        }
    }
}

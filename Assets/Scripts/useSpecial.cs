using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useSpecial : MonoBehaviour
{
    public GameObject spirit;
    public Transform position;
    public float useRate;
    private float nextFire;
    public int SP;
    public int MaxSP;
    public bool canUse = true;
    GameObject inactive;
    // Start is called before the first frame update

    void Awake()
    {
        inactive = GameObject.FindGameObjectWithTag("InactiveSpirit");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && Time.time > nextFire && canUse && SP > 0)
        {
            nextFire = Time.time + useRate;
            Destroy(inactive.gameObject);
            Instantiate(spirit, position.position, Quaternion.identity);
            SP--;
        }
    }
}

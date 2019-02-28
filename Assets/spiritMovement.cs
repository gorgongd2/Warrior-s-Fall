using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiritMovement : MonoBehaviour
{
    public float speed;
    public GameObject attack;
    //public Transform attackPosition;
    // Start is called before the first frame update
    private Vector3 position;

    void Start()
    {
        position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.0f /*&& Time.time > bossTime*/)
        {
            transform.Translate(Vector3.up * speed);
        }

        if (transform.position.x > 0.0f)
        {
            transform.Translate(Vector3.right * -speed);
        }

        if (transform.position.y >= 0.0f)
        {
            Instantiate(attack, position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

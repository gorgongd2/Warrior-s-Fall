using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    public float speed;
    public float length;
    private Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < length)
        {
            transform.Translate(Vector3.up * speed);
        }

        if(transform.position.y >= length)
        {
            transform.position = start;
        }
    }
}

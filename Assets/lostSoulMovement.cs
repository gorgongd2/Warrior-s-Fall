using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lostSoulMovement : MonoBehaviour
{
    private Vector3 Position;
 
    // Start is called before the first frame update
    void Start()
    {
        Position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Position + new Vector3(Mathf.Sin(Time.time), 0, 0);
    }
}

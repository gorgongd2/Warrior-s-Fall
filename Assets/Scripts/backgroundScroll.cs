using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    public float scrollSpeed;
    public float tileSizeZ;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector3.up * newPosition;
    }
}
//public int scrollspeed;
//public float tileSizeZ;
//public Transform background;
//private Vector3 position;

//// Start is called before the first frame update
//void Start()
//{
//    position = background.position;
//}

//// Update is called once per frame
//void Update()
//{
//    float newPosition = Mathf.Repeat(Time.time * scrollspeed, tileSizeZ);
//    transform.position = position + Vector3.forward * newPosition;
//}
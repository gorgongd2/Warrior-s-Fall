using UnityEngine;
using System.Collections;

public class ContinuousVelocity : MonoBehaviour
{
    // The Velocity
    public Vector2 velocity;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
}

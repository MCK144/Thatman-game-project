using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1.0f;
    public float maxVelocity = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        CapVelocity();
    }


    void ProcessInput()
    {
        Vector3 force = new Vector3(0, 0, 0);

        if (Input.GetKey("a"))
        {
            force.x = -speed;
        }
        if (Input.GetKey("d"))
        {
            force.x = speed;
        }

        rb.AddForce(force);
    }

    void CapVelocity()
    {
        if (rb.velocity.magnitude <= maxVelocity)
            return;

        Vector3 vel = rb.velocity.normalized;
        vel *= maxVelocity;

        rb.velocity = vel;

    }
}

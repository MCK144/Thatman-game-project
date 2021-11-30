using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThatmanMover : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 10.0f;
    float jump = 15.0f;
    bool touchingGround = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y < 1.0f && rb.velocity.y > -1.0f)
        {
            touchingGround = true;
        }
        else
        {
            touchingGround = false;
        }
        ProcessInput();
    }


    void ProcessInput()
    {
        Vector3 oldVel = rb.velocity;
        rb.velocity = new Vector3(0,oldVel.y, oldVel.z);
        
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-speed, oldVel.y, oldVel.z);
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector3(speed, oldVel.y, oldVel.z);
        }

        oldVel = rb.velocity;

        if (Input.GetKey("w"))
        {
            if (touchingGround)
            {
                rb.velocity = new Vector3(oldVel.x, jump, oldVel.z);
            }
        }

    }
}

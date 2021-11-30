using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenMover : MonoBehaviour
{
    Rigidbody2D rb;
    Transform trans;

    float maxVelocity = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oldVel = rb.velocity;
        rb.velocity = new Vector3(-maxVelocity, oldVel.y, oldVel.z);
        trans.rotation = Quaternion.identity;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonziMover : MonoBehaviour
{
    public Transform trans;
    public Rigidbody2D rb;
    float x;

    // Start is called before the first frame update
    void Start()
    {

        x = trans.position.x;

        Debug.Log(x.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = new Vector3(2, 0, 0);
        rb.AddForce(force);

    }
}

/* if (Input.GetKey("a") == true)
        {
            Vector3 newPos = new Vector3(9, 0, 0);
            transform.position.x = 0;
            //rb.AddForce(-1.0f,0.0f,0.0f);
        }
        if (Input.GetKey("d") == true)
        {
            //rb.AddForce(1.0f,0.0f,0.0f);
        }*/
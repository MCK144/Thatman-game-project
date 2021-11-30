using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThatmanAnimator : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    Transform trans;

    int prevDirection;
    int direction;
    bool punching = false;

    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //reset rotation
        trans.rotation = Quaternion.identity;

        // set direction
        if (rb.velocity.x < -1.0f)
        {
            sprite.flipX = true;
        }
        if (rb.velocity.x > 1.0f)
        {
            sprite.flipX = false;
        }
        // set punching
        if (Input.GetKey("space"))
        {
            punching = true;
        }
        else
        {
            punching = false;
        }

        animator.SetFloat("speed", Mathf.Abs(rb.velocity.magnitude));
        animator.SetBool("punching", punching);

    }
}

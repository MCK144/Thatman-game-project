using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitizenAnimator : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //set the animation speed variable
        animator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        // set the spriteDirection
        if (rb.velocity.x < 0.0f)
        {
            sprite.flipX = true;
        }

        if (rb.velocity.x > 0.0f)
        {
            sprite.flipX = false;
        }
    }
}

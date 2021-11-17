using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThatmanAnimator : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    int direction;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("speed", Mathf.Abs(rb.velocity.magnitude));

        

        if (rb.velocity.x < 1.0f)
        {
            sprite.flipX = true;
        } else
        {
            sprite.flipX = false;
        }
    }
}

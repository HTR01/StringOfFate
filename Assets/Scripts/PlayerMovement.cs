using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public bool isGrounded = true;
    public KeyCode Left,Right,Jump;
  
    public float jumpHeight,speed;
    public int horiz;
    Animator anim;


    void Start()
    {
        horiz = 0;
        anim = GameObject.Find(transform.name + "white").GetComponent<Animator>();
    }


    void Update()
    {
        horiz = 0;
        var body = GetComponent<Rigidbody2D>();
        if (Input.GetKey(Right))
        {
            horiz += 1;
            anim.SetBool("Slow Run", true);
        }
        else
        {
            anim.SetBool("Slow Run", false);
        }


        if (Input.GetKey(Left))
        {
            horiz -= 1;
            anim.SetBool("Slow Run", true);
        }

        if (horiz == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (horiz == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            anim.SetBool("Slow Run", false);
        }

        body.velocity = new Vector2(horiz * speed, body.velocity.y);

        if (Input.GetKeyDown(Jump))
        {
            if (isGrounded)
            {
                body.velocity = new Vector2(body.velocity.x, jumpHeight);

                isGrounded = false;
            }
            anim.SetTrigger("Jump up");
        }
    }

    public void ResetJump()
    {
        isGrounded = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        anim.SetTrigger("Jump down");
    }
}

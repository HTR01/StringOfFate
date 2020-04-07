using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public bool isGrounded = true;
    public KeyCode Left;
    public KeyCode Right;
    public KeyCode Jump;

    public float jumpHeight;
    public float speed;
    

    
    void Start()
    { 

    }


    void Update()
    {
        var horiz = 0;
        var body = GetComponent<Rigidbody2D>();
        if (Input.GetKey(Right))
        {
           horiz += 1;
        }

        if (Input.GetKey(Left))
        {
            horiz -= 1;
        }

        if (horiz == 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (horiz == -1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        body.velocity = new Vector2(horiz * speed, body.velocity.y);

        if (Input.GetKeyDown(Jump))
        {
            if (isGrounded)
            {
                body.velocity = new Vector2(body.velocity.x, jumpHeight);

                isGrounded = false;
                
            }
        }
    }

    public void ResetJump()
    {
        isGrounded = true;
    }
}

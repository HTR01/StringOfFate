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

        var body = GetComponent<Rigidbody2D>();
        if (Input.GetKey(Right))
        {
            //body.velocity = Vector2.right * speed * Time.deltaTime;
            body.velocity = new Vector2(speed * Time.deltaTime, body.velocity.y);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(Left))
        {
            //body.velocity = Vector2.left * speed * Time.deltaTime;
            body.velocity = new Vector2(-speed * Time.deltaTime, body.velocity.y);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown(Jump))
        {
            if (isGrounded)
            {
                body.velocity = new Vector2(body.velocity.x, jumpHeight);
                //this.transform.Translate(Vector2.up * jumpHeight * Time.deltaTime);

                

                isGrounded = false;
                
            }
        }
    }

    public void ResetJump()
    {
        isGrounded = true;
    }
}

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
    

    
    void Start()
    { 

    }


    void Update()
    {

        if (Input.GetKey(Right))
        {
            this.transform.position += Vector3.right * 8f * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(Left))
        {
            this.transform.position += Vector3.left * 8f * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown(Jump))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity += new Vector2(0, jumpHeight);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    
    public Rigidbody2D body;
    public float pickupAmount;
    public Transform pickupPos;
    


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {

    }

    public void Pickup()
    {
        //body.MovePosition(body.position + new Vector2(0, pickupAmount));
        body.constraints = RigidbodyConstraints2D.FreezePositionY;
        transform.parent = pickupPos.transform;
        transform.position = pickupPos.position;
        body.gravityScale = 0;
    }

    public void DropObject()
    {
        transform.parent = null;
    }
}

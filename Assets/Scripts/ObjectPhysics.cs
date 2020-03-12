using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    Rigidbody2D body;
    Collider2D objCol;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        objCol = GetComponent<Collider2D>();
    }


    void Update()
    {

    }

    public void Pickup(Transform pickupPos)
    {
        //body.MovePosition(body.position + new Vector2(0, pickupAmount));
        //body.constraints = RigidbodyConstraints2D.FreezePositionY;
        transform.position = pickupPos.position;
        transform.SetParent(pickupPos);
        
        body.simulated = false;
    }

    public void DropObject()
    {
        transform.parent = null;
        body.constraints = RigidbodyConstraints2D.FreezeRotation;
        
        body.simulated = true;
    }
}

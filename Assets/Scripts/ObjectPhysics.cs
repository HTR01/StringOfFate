using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPhysics : MonoBehaviour
{
    
    public Rigidbody2D body;
    public float pickupAmount;

    


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

    }

    public void Pickup()
    {
        body.MovePosition(body.position + new Vector2(0, pickupAmount));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float raiseAmount;
    public float lowerAmount;

    private Rigidbody2D body;
    public bool maxReached;
    public bool minReached;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void RaisePlatform()
    {
        if (maxReached == false) { 
            body.MovePosition(body.position + new Vector2(0, raiseAmount * Time.deltaTime));
        }
        minReached = false;
    }

    public void LowerPlatform()
    {
        if (minReached == false) {
            body.MovePosition(body.position + new Vector2(0, lowerAmount * Time.deltaTime));
        }

        maxReached = false;
    }
}

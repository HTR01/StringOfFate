using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    public float raiseAmount;
    public float lowerAmount;

    private Rigidbody2D body;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    public void RaisePlatform()
    {
        body.MovePosition(body.position + new Vector2(0, raiseAmount * Time.deltaTime));
    }

    public void LowerPlatform()
    {
        body.MovePosition(body.position + new Vector2(0, lowerAmount * Time.deltaTime));
    }

    public void StaticPlatform()
    {
        body.MovePosition(body.position + new Vector2(0, 0));
    }
}

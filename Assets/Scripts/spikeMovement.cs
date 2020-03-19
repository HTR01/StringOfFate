using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeMovement : MonoBehaviour
{
    Rigidbody2D body;
    public float moveAmount;
    public float moveTime;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        StartCoroutine(spikeAni());
    }

    // Update is called once per frame
    void Update()
    {
       /* if (this.transform.position.y == )
        {

        }*/
    }

    IEnumerator spikeAni()
    {
        body.MovePosition(body.position + new Vector2(0, moveAmount * Time.deltaTime));
        new WaitForSeconds(moveTime);
        body.MovePosition(body.position + new Vector2(0, -moveAmount * Time.deltaTime));
        new WaitForSeconds(moveTime);
        StartCoroutine(spikeAni());
        yield return null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClamp : MonoBehaviour
{
    public float minClamp;
    public float maxClamp;

    //float timeValue = 0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float yValue = Mathf.Sin(timeValue * 0.5f);

        var position = transform.position;

        float yPos = Mathf.Clamp(position.y, minClamp, maxClamp);

        
        transform.position = new Vector2(position.x, yPos);
    }
}

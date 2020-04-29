using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisClamp : MonoBehaviour
{
    public float maxChange;

    private float basePosition;
    private float minValue;
    private float maxValue;

    
    private PlatformController pc;

    void Start()
    {
        pc = GetComponent<PlatformController>();

        var startY = transform.position.y;
        var changedY = startY + maxChange;
        if (startY < changedY)
        {
            minValue = startY;
            maxValue = changedY;
        }
        else
        {
            minValue = changedY;
            maxValue = startY;
        }


    }

    // Update is called once per frame
    void Update()
    {
        //float yValue = Mathf.Sin(timeValue * 0.5f);

        var position = transform.position;

        float yPos = Mathf.Clamp(position.y, minValue, maxValue);

        if( yPos == maxValue)
        {
            pc.maxReached = true;
            
        }

        if (yPos == minValue)
        {
            pc.minReached = true;
        }

        
        transform.position = new Vector2(position.x, yPos);
    }
}

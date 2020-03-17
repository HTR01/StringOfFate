using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YAxisClamp : MonoBehaviour
{
    public float maxChange;

    private float basePosition;
    private float minValue;
    private float maxValue;

    //float timeValue = 0.0f;

    void Start()
    {
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

        
        transform.position = new Vector2(position.x, yPos);
    }
}

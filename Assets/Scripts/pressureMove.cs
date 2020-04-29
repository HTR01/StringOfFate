using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressureMove : MonoBehaviour
{
    public GameObject pressure;
    public PushPlatform platform;

    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (platform.pressureNumber == 1)
        {
            pressure.transform.position = pressure.transform.position - new Vector3(0, 1, 0);
        }
        if (platform.pressureNumber == 0)
        {

            pressure.transform.position = pressure.transform.position + new Vector3(0, 1, 0);
        }


    }
    void Update()
    {
        
    }
}

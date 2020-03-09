using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullPlatform : MonoBehaviour
{
    int pressureNumber = 0;

    public PlatformController platCont;

    void FixedUpdate()
    {
        if (pressureNumber == 1)
        {
            platCont.LowerPlatform();
        }
        if (pressureNumber == 0)
        {
            platCont.RaisePlatform();
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pressureNumber = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressureNumber = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlatform : MonoBehaviour
{
    int pressureNumber = 0;

    public PlatformController platCont;
   

   
    void FixedUpdate()
    {
        if(pressureNumber == 1)
        {
            platCont.RaisePlatform();
        }
        if(pressureNumber == 0)
        {
            platCont.LowerPlatform();
        }
       
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        pressureNumber = 1;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressureNumber = 0;
    }
}

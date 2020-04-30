using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTrack : MonoBehaviour
{
    public Vector3 camPosRight;
    public Vector3 camPosLeft;

    public KeyCode left, right;
    public PlayerMovement playM;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playM.horiz == 1)
        {
            Vector3 temp2 = camPosRight;
            this.transform.position = temp2;
        }

        if (playM.horiz == -1)
        {
            Vector3 temp2 = camPosRight;
            this.transform.position = temp2;
        }
    }
}

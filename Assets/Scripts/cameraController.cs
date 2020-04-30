using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform player;
    public PlayerMovement plaMov;

    

    void Update()
    {
        Vector2 temp = new Vector2(player.position.x, player.position.y);
        this.transform.position = temp;

        
    }
}

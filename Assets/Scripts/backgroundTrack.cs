using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundTrack : MonoBehaviour
{
    public Transform player;


    void Update()
    {
        Vector2 temp = new Vector2(player.position.x, player.position.y);
        this.transform.position = temp;
    }
}

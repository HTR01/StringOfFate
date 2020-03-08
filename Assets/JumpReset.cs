using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpReset : MonoBehaviour
{
    public PlayerMovement player;


    private void OnTriggerStay2D(Collider2D collision)
    {
        player.ResetJump();
    }
}

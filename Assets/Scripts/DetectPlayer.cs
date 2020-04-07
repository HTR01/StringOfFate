using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    public PlayerMovement closestPlayer;
    public bool isClose;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.GetComponent<PlayerMovement>() == null)
        {
            closestPlayer = gameObject.GetComponent<PlayerMovement>();
            isClose = true;
            Debug.Log("Player Detected");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gameObject.GetComponent<PlayerMovement>() == closestPlayer)
        {
            closestPlayer = null;
            isClose = false;
            Debug.Log("Player Lost");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    public Transform currentCheck;
    public GameObject checkpoint;
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    public void setCheckpoint()
    {
        currentCheck = checkpoint.transform;
    }

    public void Respawn()
    {
        //Instantiate(player, checkpoint.transform);
        player.transform.position = checkpoint.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointManager : MonoBehaviour
{
    public checkpoints checkP;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            checkP.checkpoint = this.gameObject;
            checkP.setCheckpoint();
            Debug.Log("Set checkpoint");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour
{
    public Transform currentCheck;
    public GameObject checkpoint;
    

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        currentCheck = checkpoint.transform;
    }
}

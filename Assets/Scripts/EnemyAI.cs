using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public DetectPlayer detect;
    public GameObject mon;
    public GameObject player;
    public float moveSpeed;
    //Transform monPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detect.isClose /*&& Time.timeScale == 1*/)
        {
            Debug.Log("Moving");
            //monPos = mon.transform;
            transform.position = Vector2.MoveTowards(mon.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }  
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Time.timeScale = 1;
        }
    }
}

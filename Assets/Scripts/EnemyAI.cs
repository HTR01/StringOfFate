using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public DetectPlayer detect;
    public GameObject mon;
    public GameObject player;
    public float moveSpeed;
    public Vector2 home;
    public checkpoints checkP;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detect.isClose /*&& Time.timeScale == 1*/)
        {
            Debug.Log("Moving");
            
            transform.position = Vector2.MoveTowards(mon.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (!detect.isClose )
        {
            Debug.Log("Going home");
            
            transform.position = Vector2.MoveTowards(mon.transform.position, home, moveSpeed * Time.deltaTime);
            //transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            Time.timeScale = 1;
        }

        transform.LookAt(player.transform);
    }
}

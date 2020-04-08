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
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (detect.isClose /*&& Time.timeScale == 1*/)
        {
            Debug.Log("Moving");
            
            transform.position = Vector2.MoveTowards(mon.transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }
        if (!detect.isClose )
        {
            Debug.Log("Going home");
            
            transform.position = Vector2.MoveTowards(mon.transform.position, home, moveSpeed * Time.deltaTime);
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            checkP.Respawn();
            Debug.Log("Respawned");

        }
    }
}

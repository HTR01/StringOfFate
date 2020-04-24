using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private Stat health;
    public checkpoints checkP;

    // Start is called before the first frame update
    private void Awake()
    {
        health.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            health.CurrentVal += 10;
        }

        if (health.CurrentVal == 0)
        {
            checkP.Respawn();
            health.CurrentVal = 100;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            Debug.Log("Took damage");
            health.CurrentVal -= 30;
        }

        if (other.gameObject.CompareTag("Spike"))
        {
            Debug.Log("Took damage");
            health.CurrentVal -= 100;
        }


    }
}

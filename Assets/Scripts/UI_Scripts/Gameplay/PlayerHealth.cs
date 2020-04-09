using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private Stat health;

    // Start is called before the first frame update
    private void Awake()
    {
        health.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            health.CurrentVal += 10;
        }
    }
}

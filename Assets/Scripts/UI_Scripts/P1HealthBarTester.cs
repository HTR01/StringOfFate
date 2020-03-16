using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1HealthBarTester : MonoBehaviour
{

    private HealthBarController healthBar;

    private void Awake()
    {
        healthBar = GameObject.Find("P1 Health Bar").GetComponent<HealthBarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            healthBar.changeHP(-10);
        }
    }
}

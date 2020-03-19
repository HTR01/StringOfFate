using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1HealthBarTester : MonoBehaviour
{

    private HealthBarController healthBar;
    private Slider healthValue;
    public Renderer rend;

    private void Awake()
    {
        healthBar = GameObject.Find("P1 Health Bar").GetComponent<HealthBarController>();
        healthValue = GameObject.Find("P1 Health Bar").GetComponent<Slider>();
        rend = GameObject.Find("Heart").GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            healthBar.changeHP(-10);
        }
    }

    /*void FinalHealth()
    {
        if( healthBar.currentHP = 0)
        {

        }
    }*/
}

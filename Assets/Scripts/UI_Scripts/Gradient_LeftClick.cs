﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gradient_LeftClick : MonoBehaviour
{
    private Slider healthBar;
    private int currentHP = 100;

    private void Awake()
    {
        healthBar = GetComponent<Slider>();
    }

    private void Update()
    {
        healthBar.value = currentHP;
    }

    public void changeHP(int dHP)
    {
        currentHP += dHP;
    }

    public void HealthDamage()
    {
        if(Input.GetMouseButtonDown(0))
        {
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider healthBar;
    public int currentHP = 100;

    private void Awake()
    {
        healthBar = GetComponent<Slider>();
    }

    public void Update()
    {
        healthBar.value = currentHP;
    }

    public void changeHP(int dHP)
    {
        currentHP += dHP;
    }
}

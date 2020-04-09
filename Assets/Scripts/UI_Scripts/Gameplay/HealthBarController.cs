using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    private float fillAmount;

    [SerializeField]
    private float lerpSpeed;

    [SerializeField]
    private Image Health_Fill1;
    [SerializeField]
    private Image Health_Fill2;

    public float MaxValue { get; set; }

    public float Value
    {
        set
        {
            fillAmount = DamageHP(value, 0, MaxValue, 0, 1);
        }
    }


    public float currentHP = 1;


    public void Update()
    {
        HandleBar();
    }

    public void HandleBar()
    {
        if(fillAmount != Health_Fill1.fillAmount)
        {
            Health_Fill1.fillAmount = Mathf.Lerp(Health_Fill1.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }
        if (fillAmount != Health_Fill2.fillAmount)
        {
            Health_Fill2.fillAmount = Mathf.Lerp(Health_Fill2.fillAmount, fillAmount, Time.deltaTime * lerpSpeed); ;
        }
    }

    private float DamageHP(float value, float inMin, float inMax, float outMin,float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }

    public void changeHP(int dHP)
    {
        currentHP += dHP;
    }
}

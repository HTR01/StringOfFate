using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGradient : MonoBehaviour
{
    public Color A = Color.magenta;
    public Color B = Color.red;
    public float speed = 1.0f;

    Image spriteRenderer;

    GameObject health;

    private void Start()
    {
        spriteRenderer = GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = Color.Lerp(A, B, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}

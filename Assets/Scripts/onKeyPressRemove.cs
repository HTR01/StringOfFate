using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onKeyPressRemove : MonoBehaviour
{
    public GameObject controls;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            controls.SetActive(false);
            Time.timeScale = 1;
        }
    }
}

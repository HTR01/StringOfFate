using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titleShow : MonoBehaviour
{
    public GameObject credits;
    public GameObject title;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            credits.SetActive(false);
            title.SetActive(true);
        }
    }
}

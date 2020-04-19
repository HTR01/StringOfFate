using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public static int levelValue;
    public int neededLevelValue;

    public string levelToLoad;

    void Start()
    {
        levelValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(levelValue == 2)
        {
            SceneManager.LoadScene(2);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene(levelToLoad);
        }
    }
}

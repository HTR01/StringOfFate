using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject inGameUI;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        inGameUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void InGameUI()
    {
        if(GameIsPaused)
        {

            inGameUI.SetActive(false);
        }
        else
        {
            inGameUI.SetActive(true);
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadSettings()
    {
        Debug.Log("Loading Settings...");
    }

    public void LoadMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}

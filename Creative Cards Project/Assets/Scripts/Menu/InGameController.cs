using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameController : MonoBehaviour {

    public GameObject PauseCanvasObject;
    public GameObject ControlsCanvasObject;

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            TogglePauseMenu();
        }

    }

    public void OnStartNewGame()
    {
        Debug.LogWarning("Load level 1");
        SceneManager.LoadScene("TestLevel");
    }

    public void OnDeath()
    {
        Debug.LogWarning("death");
        SceneManager.LoadScene("Scenes/youdied");
    }

    public void OnGotoWrapper()
    {
        Debug.LogWarning("death");
        SceneManager.LoadScene("Scenes/wrapper");
    }

    public void OnQuit()
    {
        Debug.LogWarning("quit game completely");
        Application.Quit();
    }

    public void Controls()
    {
        Debug.LogWarning("Open Controls");
        ToggleControlsMenu();
    }

    public void GoToStart()
    {
        Debug.LogWarning("Open Start Menu");
        SceneManager.LoadScene("Start");
    }

    public void Continue()
    {
        TogglePauseMenu();
    }


    public void TogglePauseMenu()
    {
        if (ControlsCanvasObject.activeInHierarchy == false)
        {
            if (PauseCanvasObject.activeInHierarchy == true)
            {
                PauseCanvasObject.SetActive(false);
                Time.timeScale = 1.0f;
            }
            else
            {
                PauseCanvasObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ToggleControlsMenu()
    {
        if (PauseCanvasObject.activeInHierarchy == true)
        {
            PauseCanvasObject.SetActive(false);
            ControlsCanvasObject.SetActive(true);
        }
        else
        {
            PauseCanvasObject.SetActive(true);
            ControlsCanvasObject.SetActive(false);
        }
    }
}

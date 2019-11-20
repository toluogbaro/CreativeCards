using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public void OnStartNewGame()
    {
        Debug.LogWarning("Load level 1");
        SceneManager.LoadScene("TylerTesting");
    }

    public void GoToMenu()
    {
        Debug.LogWarning("Open Start Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void OnQuit()
    {
        Debug.LogWarning("quit game completely");
        Application.Quit();
    }
}

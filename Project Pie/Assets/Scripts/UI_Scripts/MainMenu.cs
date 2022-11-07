using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("HUB");
        DataPersistenceManager.instance.NewGame();
        Time.timeScale = 1f;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("HUB");
        DataPersistenceManager.instance.LoadGame();
        Time.timeScale = 1f;
    }

    public void MainMenuScreen()
    {
        SceneManager.LoadScene("MainMenu");
        DataPersistenceManager.instance.LoadGame();
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}

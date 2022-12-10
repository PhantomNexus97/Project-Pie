using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        FindObjectOfType<AudioManager>().Play("UI_Click");
        SceneManager.LoadScene("HUB");
        DataPersistenceManager.instance.NewGame();
        Time.timeScale = 1f;
    }

    public void LoadGame()
    {
        FindObjectOfType<AudioManager>().Play("UI_Click");
        SceneManager.LoadScene("HUB");
        DataPersistenceManager.instance.LoadGame();
        Time.timeScale = 1f;
    }

    public void MainMenuScreen()
    {
        FindObjectOfType<AudioManager>().Play("UI_Click");
        SceneManager.LoadScene("MainMenu");
        DataPersistenceManager.instance.LoadGame();
    }

    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("UI_Click");
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void UI_Click()
    {
        FindObjectOfType<AudioManager>().Play("UI_Click");
    }

    public void UI_PageTurn()
    {
        FindObjectOfType<AudioManager>().Play("UI_PageTurn");
    }
}

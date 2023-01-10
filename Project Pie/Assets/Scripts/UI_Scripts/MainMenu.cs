using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Called when the player clicks on the "New Game" button in the main menu
    public void NewGame()
    {
        // Play a sound effect when the button is clicked
        // Load the "HUB" scene, which is the starting area of the game
        // Initialize a new game
        // Restore the normal flow of time in the game
        FindObjectOfType<AudioManager>().Play("UI_Click");
        SceneManager.LoadScene("HUB");
        DataPersistenceManager.instance.NewGame();
        Time.timeScale = 1f;
    }

    // Called when the player clicks on the "Load Game" button in the main menu
    public void LoadGame()
    {
        // Play a sound effect when the button is clicked
        // Load the "HUB" scene, which is the starting area of the game
        // Load a previously saved game
        // Restore the normal flow of time in the game
        FindObjectOfType<AudioManager>().Play("UI_Click");
        SceneManager.LoadScene("HUB");
        DataPersistenceManager.instance.LoadGame();
        Time.timeScale = 1f;
    }

    // Called when the player clicks on the "Main Menu" button in the game
    public void MainMenuScreen()
    {
        // Play a sound effect when the button is clicked
        // Load the "MainMenu" scene
        // Load the previously saved game, if any
        FindObjectOfType<AudioManager>().Play("UI_Click");
        SceneManager.LoadScene("MainMenu");
        DataPersistenceManager.instance.LoadGame();
    }

    // Called when the player clicks on the "Quit" button in the game
    public void QuitGame()
    {
        // Play a sound effect when the button is clicked
        // Log a message in the console
        // Quit the game
        FindObjectOfType<AudioManager>().Play("UI_Click");
        Debug.Log("Quit!");
        Application.Quit();
    }

    // Called when the player clicks on certain UI elements in the game
    public void UI_Click()
    {
        // Play the "UI_Click" sound effect
        FindObjectOfType<AudioManager>().Play("UI_Click");
    }

    // Called when the player clicks on certain UI elements in the game
    public void UI_PageTurn()
    {
        // Play the "UI_PageTurn" sound effect
        FindObjectOfType<AudioManager>().Play("UI_PageTurn");
    }
}

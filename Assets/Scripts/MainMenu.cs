using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private string firstLevelScene;
    [SerializeField] private string instructionsScene;
    [SerializeField] private string MainMenuScene;

    [SerializeField] GameObject startNewGameButton;
    [SerializeField] GameObject instructionsButton;
    [SerializeField] GameObject quitButton;
    [SerializeField] GameObject backButton;

    [SerializeField] GameObject title;
    [SerializeField] GameObject Instrutions;


    public void StartNewGame()
    {
        SceneManager.LoadScene(firstLevelScene);
    }

    public void OpenInstructionsMenu()
    {
        enableMainMenuUI(false);
        enableInstructionsUI(true);
    }

    public void BackToMainMenu()
    {
        enableMainMenuUI(true);
        enableInstructionsUI(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void enableMainMenuUI(bool enabled)
    {
        title.SetActive(enabled);
        startNewGameButton.SetActive(enabled);
        instructionsButton.SetActive(enabled);
        quitButton.SetActive(enabled);
    }

    private void enableInstructionsUI(bool enabled)
    {
        Instrutions.SetActive(enabled);
        backButton.SetActive(enabled);
    }
}

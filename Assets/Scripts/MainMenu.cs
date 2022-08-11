using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] private string firstLevelScene;
    [SerializeField] private string instructionsScene;
    [SerializeField] private string MainMenuScene;



    public void StartNewGame()
    {
        SceneManager.LoadScene(firstLevelScene);
    }

    public void OpenInstructionsMenu()
    {
        SceneManager.LoadScene(instructionsScene);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(MainMenuScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

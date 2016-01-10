using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameStartEndOld : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ContactDeveloper()
    {
        SceneManager.LoadScene(2);
    }

    public void loadCredits()
    {
        SceneManager.LoadScene(3);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}

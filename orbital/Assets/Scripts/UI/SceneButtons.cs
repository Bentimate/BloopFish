using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButtons : MonoBehaviour
{
    public void HighScore()
    {
        SceneManager.LoadScene("Highscore");
    }
    public void restartButton()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void homeButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void nextScene()
    {
        // load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void prevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}

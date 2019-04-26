using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    

    public void StartIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void StartMain()
    {
        Fruit.cutFruit = 0;
        Fruit.unharmedFruit = 0;
        SceneManager.LoadScene("Main");
    }

    public void StartScores()
    {
        SceneManager.LoadScene("ShowScores");
    }

    public void StartGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        //exit application for real:
        // Application.Quit();

        // for development:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

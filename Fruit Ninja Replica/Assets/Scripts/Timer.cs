using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    [SerializeField]
    private Text timerText;

    float timeLeft = Settings.gameModeTimer;

    // Use this for initialization
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time: " + timeLeft.ToString("0");
        if(timeLeft > 120)
        {
            timerText.text = "Time: N/A";
        }
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");

            
        }
    }
}

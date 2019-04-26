using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class ReadScores : MonoBehaviour
{
    public Text HighScoreText;
    int scorerNumber = 1;

    public static string thePlayerName;
    public InputField PlayerNameInputField;

    // Start is called before the first frame update
    public void ShowScores() // we read the file on loading the page, the script is attached to the camera so it will always run.
    {
        int playerScore; // first field in record
        string playerName; // second field in record
        string[] readText; // array of lines in file
        string[] fields; // fields in the line
        string path = "Assets/Resources/scores.txt";
        

        readText = File.ReadAllLines(path);

        foreach (string line in readText)
        {
            fields = line.Split(',');
            playerScore = Convert.ToInt32(fields[0]);
            playerName = fields[1];

            Debug.Log("playerName: " + playerName);
            if (scorerNumber <= 5 && playerName == (thePlayerName))
            {
                HighScoreText.text += scorerNumber + ". " + playerName + " - " + playerScore + "\n";
                scorerNumber++;
                Debug.Log("Match");
            }
            
        }
        if (scorerNumber == 1)
        {
            HighScoreText.text += "No scores entered for this name";
        }
        
    }

    public void ConfirmName()
    {
        if (string.IsNullOrEmpty(PlayerNameInputField.text))
        {
            thePlayerName = "Anonymous";
        }
        else
        {
            thePlayerName = PlayerNameInputField.text;
        }

        Debug.Log("thePlayerName: " + thePlayerName);
        
    }

    
    
}

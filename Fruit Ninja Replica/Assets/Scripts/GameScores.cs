using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScores : MonoBehaviour
{


    public Text CurrentInfoText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentInfoText.text = "Player: " + ReadScores.thePlayerName +"\nFruit unharmed: " + Fruit.unharmedFruit.ToString() + "\nFruit cut: " + Fruit.cutFruit.ToString() + "\nBombs Hit: " + Bomb.bombsHit;
        
    }
}

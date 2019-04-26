using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public static bool areHazards;

    public Dropdown FruitSizeDropdown;
    public Dropdown FruitSpawnSpeedDropdown;
    public Dropdown FruitSpeedDropdown;
    public Dropdown BladeSizeDropdown;
    public Dropdown GameModeDropDown;

    public static float fruitSpeed = 15f;
    public static float fruitSpawnSpeedMinimum = .1f;
    public static float fruitSpawnSpeedMaximum = 1f;
    public static float fruitSizeMultiplier = 1f;
    public static float bladeSizeWidth = .1f;
    public static float gameModeTimer = 60f;
    

    void Update()
    {
        switch (FruitSizeDropdown.value)
        {
            case 1:
                fruitSizeMultiplier = .5f;
                break;
            case 2:
                fruitSizeMultiplier = 1f;
                break;
            case 3:
                fruitSizeMultiplier = 2f;
                break;
            default:
                fruitSizeMultiplier = 1f;
                break;
        }

        switch (FruitSpawnSpeedDropdown.value)
        {
            case 1:
                fruitSpawnSpeedMinimum = 1f;
                fruitSpawnSpeedMaximum = 2f;

                break;
            case 2:
                fruitSpawnSpeedMinimum = .1f;
                fruitSpawnSpeedMaximum = 1f;
                break;
            case 3:
                fruitSpawnSpeedMinimum = .05f;
                fruitSpawnSpeedMaximum = .5f;
                break;
            default:
                fruitSpawnSpeedMinimum = .1f;
                fruitSpawnSpeedMaximum = 1f;
                break;
        }

        switch (FruitSpeedDropdown.value)
        {
            case 1:
                fruitSpeed = 12f;
                break;
            case 2:
                fruitSpeed = 16f;
                break;
            case 3:
                fruitSpeed = 20f;
                break;
            default:
                fruitSpeed = 15f;
                break;
        }

        switch (BladeSizeDropdown.value)
        {
            case 1:
                bladeSizeWidth = .06f;
                break;
            case 2:
                bladeSizeWidth = .1f;
                break;
            case 3:
                bladeSizeWidth = .3f;
                break;
            default:
                bladeSizeWidth = .1f;
                break;
        }

        switch (GameModeDropDown.value)
        {
            case 1:
                gameModeTimer = 60f;
                break;
            case 2:
                gameModeTimer = 120f;
                break;
            case 3:
                gameModeTimer = 999999999999999999f;
                break;
            default:
                gameModeTimer = 60f;
                break;
        }
    }

    public void HazardsToggle(bool hazards)
    {
        if (hazards == true)
        {
            Debug.Log(hazards);
            areHazards = true;
        }
        if (hazards == false)
        {
            Debug.Log(hazards);
            areHazards = false;
        }
    }
}

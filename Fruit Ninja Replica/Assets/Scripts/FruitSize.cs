using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(Settings.fruitSizeMultiplier, Settings.fruitSizeMultiplier, Settings.fruitSizeMultiplier);
    }

}

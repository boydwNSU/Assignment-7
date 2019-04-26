using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FruitSpawner : MonoBehaviour {

	public GameObject fruitPrefab;
	public Transform[] spawnPoints;

    public static int unharmedFruit = 0;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(SpawnFruits());
	}
    

    IEnumerator SpawnFruits ()
	{
		while (true)
		{
            float delay = Random.Range(Settings.fruitSpawnSpeedMinimum, Settings.fruitSpawnSpeedMaximum);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
			Destroy(spawnedFruit,5f);
            
		}
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "outOfBounds")
        {
            Debug.Log("Miss");
            unharmedFruit++;
        }

    }

}

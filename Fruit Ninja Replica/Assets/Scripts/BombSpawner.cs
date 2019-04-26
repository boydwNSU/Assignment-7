using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombSpawner : MonoBehaviour
{

    public GameObject bombSpawner;
    
    public GameObject bombPrefab;
    public Transform[] spawnPoints;

    public float minDelay = 1f;
    public float maxDelay = 5f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnBombs());

        if (Settings.areHazards == true)
        {
            bombSpawner.gameObject.SetActive(true);
        }
        if (Settings.areHazards == false)
        {
            bombSpawner.gameObject.SetActive(false);
        }
    }

    IEnumerator SpawnBombs()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[spawnIndex];

            GameObject spawnedBomb = Instantiate(bombPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnedBomb, 5f);
        }
    }
}

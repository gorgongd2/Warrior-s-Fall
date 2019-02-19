using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public Vector2 spawnArea;
    public int numberofEnemies;
    public float timeBeforeStart;
    public float timeBetweenWaves;
    public float timeBetweenSpawns;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startTime());
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        while (true)
        {
            for (int i = 0; i < numberofEnemies; i++)
            {
                Vector2 spawnpoint = new Vector2(Random.Range(-spawnArea.x, spawnArea.x), spawnArea.y);
                Instantiate(enemy, spawnpoint, Quaternion.identity);
                StartCoroutine(spawnTime());
            }
            StartCoroutine(waveTime());
        }
    }
        

    IEnumerator startTime()
    {
        yield return new WaitForSeconds(timeBeforeStart);
    }

    IEnumerator waveTime()
    {
        yield return new WaitForSeconds(timeBetweenWaves);
    }

    IEnumerator spawnTime()
    {
        yield return new WaitForSeconds(timeBetweenSpawns);
    }
}

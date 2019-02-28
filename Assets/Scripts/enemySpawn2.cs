using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn2 : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector2 spawnArea;
    public int numberofEnemies;
    public float timeBeforeStart;
    public float timeBetweenWaves;
    public float timeBetweenSpawns;
    public float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startTime());
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (Time.timeSinceLevelLoad < spawnTime)
        {
            //if (Time.time < spawnTime)
            //{
            yield return new WaitForSeconds(timeBeforeStart);
            for (int i = 0; i < numberofEnemies; i++)
            {
                GameObject enemy = enemies[i];
                Vector2 spawnpoint = new Vector2(Random.Range(-spawnArea.x, spawnArea.x), spawnArea.y);
                Instantiate(enemy, spawnpoint, Quaternion.identity);
                yield return new WaitForSeconds(timeBetweenSpawns);
            }
            StartCoroutine(waveTime());
       // }
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

    
}

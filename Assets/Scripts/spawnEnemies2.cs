using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies2 : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector2 spawnArea;
    public int numberofEnemies;
    public float timeBeforeStart;
    public float timeBetweenWaves;
    public float timeBetweenSpawns;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startTime());
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeBeforeStart);
            for (int i = 0; i < numberofEnemies; i++)
            {
                GameObject enemy = enemies[i];
                Vector2 spawnpoint = new Vector3(Random.Range(-spawnArea.x, spawnArea.x), spawnArea.y);
                Instantiate(enemy, spawnpoint, Quaternion.identity);
                //StartCoroutine(spawnTime());
                yield return new WaitForSeconds(timeBetweenSpawns);
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

    /* IEnumerator spawnTime()
     {
         yield return new WaitForSeconds(timeBetweenSpawns);
     }*/

    //public GameObject hazard;
    //public Vector3 spawnValues;
    //public int hazardCount;
    //public float spawnWait;
    //public float startWait;
    //public float waveWait;

    //void Start()
    //{
    //    StartCoroutine(SpawnWaves());
    //}

    //IEnumerator SpawnWaves()
    //{
    //    yield return new WaitForSeconds(startWait);
    //    while (true)
    //    {
    //        for (int i = 0; i < hazardCount; i++)
    //        {
    //            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
    //            Quaternion spawnRotation = Quaternion.identity;
    //            Instantiate(hazard, spawnPosition, spawnRotation);
    //            yield return new WaitForSeconds(spawnWait);
    //        }
    //        yield return new WaitForSeconds(waveWait);
    //    }
    //}
}

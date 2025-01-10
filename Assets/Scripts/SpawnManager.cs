using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    // Start is called before the first frame update

    public float spawnRange = 9f;

    public GameObject powerup;

    public int waveNumber = 1;
    void Start()
    {

        //Instantiate(enemy, GenerateSpawnPosition(), transform.rotation);
        SpawnEnemyWave(waveNumber);
        Instantiate(powerup, GenerateSpawnPosition(), transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        int enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerup, GenerateSpawnPosition(), transform.rotation);

        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnX = Random.Range(-spawnRange, spawnRange);
        float spawnY = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(spawnX, 0, spawnY);
        return spawnPos;
    }


    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemy, GenerateSpawnPosition(), transform.rotation);

        }
    }
}

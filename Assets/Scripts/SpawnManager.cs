using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPos(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPos()
    {
        float randomPosX = Random.Range(-spawnRange, spawnRange);
        float randomPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(randomPosX, 0, randomPosZ);

        return spawnPos;
    }
}

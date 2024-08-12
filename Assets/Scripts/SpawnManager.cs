using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefabs, GenerateSpawnPosition(), enemyPrefabs.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float X = Random.Range(-spawnRange, spawnRange);
        float Z = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPos = new Vector3(X, 0, Z);
        return spawnPos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Enemy_Spawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] spawns;

    private GameObject enemyRef;
    private Transform spawnRef;

    private float spawnTime = 1f;
    private float spawnDelay = 1f;
    private bool stopSpawning = false;

    void Start()
    {
        InvokeRepeating("SetSpawn", spawnTime, spawnDelay);
    }

    Transform GetRandomSpawnPoint(Transform[] spawnArray)
    {
        int index = Random.Range(0, spawnArray.Length);

        return spawnArray[index];
    }

    GameObject GetRandomEnemy(GameObject[] enemies)
    {
        int index = Random.Range(0, enemies.Length);

        return enemies[index];
    }

    void SetSpawn()
    {
        spawnRef = GetRandomSpawnPoint(spawns);
        enemyRef = GetRandomEnemy(enemies);

        var clone = Instantiate(enemyRef, spawnRef.position, Quaternion.identity);
        if (stopSpawning) { CancelInvoke("SetSpawn"); }
        
    }
}

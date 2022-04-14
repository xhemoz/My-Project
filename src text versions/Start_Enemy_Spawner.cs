using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Enemy_Spawner : MonoBehaviour
{
    [SerializeField]
    public GameObject[] enemies;
    [SerializeField]
    public Transform[] spawns;

    private GameObject enemyRef;
    private Transform spawnRef;


    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SetSpawn", 1f, 1f);
        for(int i = 0; i<= 3; i++)
        {
            Invoke("SetSpawn", .5f);
        }
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
    }
}

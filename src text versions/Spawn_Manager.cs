using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject[] enemy;

    private float spawnRangeX = 5f;
    private float spawnPosZ = 1f;
    private Transform spawnY;

    private float countdownTime = 10f;
    public TextMeshProUGUI countdownText = null;
    private bool isTimerRunning;
    private float timeDelay = 10f;

    void Start()
    {
        spawnY = this.GetComponentInParent<Transform>();
        isTimerRunning = true;
        StartCoroutine(RandomEnemySpawns(timeDelay));
    }
    void Update()
    {
        if (isTimerRunning)
        {
            if (countdownTime > 0f)
            {
                countdownTime -= Time.deltaTime;
                countdownText.GetTextInfo(countdownTime.ToString("f0"));
            }
        }
        else
        {
            countdownTime = 0f;
        }
        if (countdownTime < 0)

        {
            countdownText.gameObject.SetActive(false);
        }
    }
    IEnumerator RandomEnemySpawns(float timeBetweenSpawns)
    {
        yield return new WaitForSeconds(timeBetweenSpawns);
        SpawnEnenmy();
        StartCoroutine(RandomEnemySpawns(1.5f));
    }
    void SpawnEnenmy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnY.transform.position.y, spawnPosZ);
        int enemyIndex = Random.Range(0, enemy.Length);
        Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);
    }
}
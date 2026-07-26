using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ElmanGameDevTools.PlayerSystem.PlayerController;

public class Enemyspawn : MonoBehaviour
{
    [Header("Enemy Types")]
    public GameObject BasicEnemy;
    public GameObject RangedEnemy;

    [Header("Spawn Var")]
    public float spawnRadiusX = 5f;
    public float spawnRadiusZ = 6f;

    [Header("SpawnerController")]
    public float spawnTimeInterval = 1f;
    public float NumOfESpawned;
    public float MaxNumOfE = 49f;
    public bool SpawningEnabled = true;
    
    public Waves CurrentWave;

    private void Awake()
    {
        StartCoroutine(RangedEnemyLogic());
    }
    private void Start()
    {
        StartCoroutine(BasicEnemyLogic());
    }

    private void Update()
    {
        if (NumOfESpawned >= MaxNumOfE)
        {
            SpawningEnabled = false;
        }
    }
    IEnumerator BasicEnemyLogic()
    {
            yield return new WaitForSeconds(spawnTimeInterval);
            Vector3 randomSpawnPoint = new Vector3(Random.Range(-spawnRadiusX, spawnRadiusX), 0f, Random.Range(-spawnRadiusZ, spawnRadiusZ));
            Instantiate(BasicEnemy, randomSpawnPoint, Quaternion.identity);
            NumOfESpawned++;
            if (SpawningEnabled)
            {
                StartCoroutine(BasicEnemyLogic());
            }
    }

    IEnumerator RangedEnemyLogic()
    {
        yield return new WaitForSeconds(spawnTimeInterval);
        Vector3 randomSpawnPoint = new Vector3(Random.Range(-spawnRadiusX, spawnRadiusX), 0f, Random.Range(-spawnRadiusZ, spawnRadiusZ));
        Instantiate(RangedEnemy, randomSpawnPoint, Quaternion.identity);
        NumOfESpawned++;
        if (SpawningEnabled)
        {
            StartCoroutine(RangedEnemyLogic());
        }
    }

    public enum Waves
    {
        Wave1,
        Wave2,
        wave3,
        wave4
    }
}

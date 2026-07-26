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
    public float Wave1Enemys = 29;
    public float Wave2Enemys = 49;
    public float Wave3Enemys = 79;
    public bool SpawningEnabled = true;
    private float MaxNumOfE;
    
    public Waves CurrentWave;

    private void Awake()
    {
        StartCoroutine(RangedEnemyLogic());
    }
    private void Start()
    {
        WaveHander();
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
        Wave3,
        Wave4
    }

    public void WaveHander()
    {
        if(CurrentWave == Waves.Wave1)
        {
            MaxNumOfE = Wave1Enemys;
            SpawningEnabled = true;
        }

        if (CurrentWave == Waves.Wave2)
        {
            MaxNumOfE = Wave2Enemys;
            SpawningEnabled = true;
        }

        if (CurrentWave == Waves.Wave3)
        {
            MaxNumOfE = Wave3Enemys;
            SpawningEnabled = true;
        }
    }
}

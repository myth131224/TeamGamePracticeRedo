using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRadiusX = 5f;
    public float spawnRadiusZ = 6f;
    public bool spawnEnabled = true;
    public float spawnTimeInterval = 1f;
    public float NumOfESpawned ;
    public float MaxNumOfE = 50f;
  

    // Update is called once per frame
    void Update()
    {
        if (spawnEnabled)
        { 
        Vector3 randomSpawnPoint= new Vector3(Random.Range(-spawnRadiusX, spawnRadiusX), 0f, Random.Range(-spawnRadiusZ, spawnRadiusZ));
        Instantiate(enemyPrefab, randomSpawnPoint, Quaternion.identity);
            NumOfESpawned++;
        }

        if (NumOfESpawned == MaxNumOfE)
        {
            spawnEnabled = false;
        }
    }

}

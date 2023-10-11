using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnManager : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    private float spawnRangex = 17.5f;
    private float spawnposZ = 20f; 
    private float startDelay = 5f;
    private float startInterval = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnRandomPowerUp", startDelay, startInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnRandomPowerUp()
    { 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex),0, spawnposZ);
        int prefabsIndex = Random.Range(0,powerUpPrefabs.Length);
        Instantiate(powerUpPrefabs[prefabsIndex],spawnPos, powerUpPrefabs[prefabsIndex].transform.rotation);
    }
}

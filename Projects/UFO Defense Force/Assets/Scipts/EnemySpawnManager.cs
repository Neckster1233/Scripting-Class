using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
	public GameObject [] ufoPrefabs;
	private float spawnRangex = 20f;
	private float spawnposZ = 20f; 
	private float startDelay = 2f;
	private float StartInterval = 1.5f;

	void Start()
	{
		InvokeRepeating("spawnRandomUFO", startDelay, StartInterval);
	}
    // Update is called once per frame
    void Update()
    {
		
    }
	
	void spawnRandomUFO()
	{
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex),0, spawnposZ);
		int ufoIndex = Random.Range(0,ufoPrefabs.Length);
		Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation);
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = -20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, 1), 1.5f, spawnPosZ);

        Instantiate(ballPrefabs[animalIndex], spawnPos, ballPrefabs[animalIndex].transform.rotation);
    }
}

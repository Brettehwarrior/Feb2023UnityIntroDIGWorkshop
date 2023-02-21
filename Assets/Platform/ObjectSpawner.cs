using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float repeatRate;
    [SerializeField] private float radius;

    private void Start()
    {
        InvokeRepeating("SpawnObject", 0f, repeatRate);
    }

    private void SpawnObject()
    {
        Vector3 spawnPoint = transform.position;
        spawnPoint.x = Random.Range(-radius, radius);
        
        Instantiate(objectToSpawn, spawnPoint, Quaternion.identity);
    }
}

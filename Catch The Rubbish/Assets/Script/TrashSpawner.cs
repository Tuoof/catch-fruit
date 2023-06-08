using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    int pickObject;
    public List<GameObject> spawnedObjects = new();

    void Start()
    {

    }

    void Update()
    {

    }

    public void SpawnRandom(Vector3 spawnLoc, Quaternion spawnRot)
    {
        pickObject = UnityEngine.Random.Range(0, spawnedObjects.Count);
        Instantiate(spawnedObjects[pickObject], spawnLoc, spawnRot);
    }
}

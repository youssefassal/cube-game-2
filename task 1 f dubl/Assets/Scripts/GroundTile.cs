using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacles();
    }

    private void OnTriggerExit(Collider other) 
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacles()
    {
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}

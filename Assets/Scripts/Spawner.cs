using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("SpawnRange")]
    public Transform xRangeLeft;
    public Transform xRangeRight;
    public GameObject targetCamera;

    [Header("Enemigos")]
    public GameObject enemies;

    [Header("Tiempos de aparicion")]
    public float timeSpawn = 1f;
    public float repeatSpawnRate = 7f;
    public float timeEnemieDestroy = 10f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemies", timeSpawn, repeatSpawnRate);
    }


    public void spawnEnemies()
    {

        GameObject enemiesInstance = Instantiate(enemies);
        enemiesInstance.transform.SetParent(transform.parent);

        Vector3 spawnPosition = new Vector3(0, 0, 0);

        spawnPosition = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), targetCamera.transform.position.y + 10f, 0);

        GameObject enemie = Instantiate(enemiesInstance, spawnPosition, gameObject.transform.rotation);

        Destroy(enemiesInstance, timeEnemieDestroy);
    }
}

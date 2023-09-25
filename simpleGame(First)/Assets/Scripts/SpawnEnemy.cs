using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float minSpawnTime=3.0f;
    public float maxSpawnTime=8.0f;
    public float xAxis = -10.0f;
    public float yAxis = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(minSpawnTime, maxSpawnTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        Instantiate(enemy, new Vector2(xAxis,yAxis), enemy.transform.rotation);
        Invoke("Spawn", Random.Range(minSpawnTime, maxSpawnTime));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2.0f,Random.Range(1.0f,3.5f));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(Obstacle,new Vector2(12.0f,Random.Range(-5.3f,-0.8f)), Obstacle.transform.rotation);
    }
}

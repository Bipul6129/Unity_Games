using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float enemySpeed = 3.0f;
    private Vector2 targetpos;
    public GameObject enemyBullet;
    private bool fired = false;
    private float firedtime;
    public float minFireRate = 1.0f;
    public float maxFireRate = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Working");
        targetpos = new Vector2(transform.position.x, transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        if (fired == false)
        {
            Instantiate(enemyBullet, new Vector2(transform.position.x, transform.position.y), enemyBullet.transform.rotation);
            fired = true;
            firedtime = Time.time;
        }

        if(Time.time-firedtime >= Random.Range(minFireRate, maxFireRate))
        {
            fired = false;
        }

        if (Mathf.FloorToInt(targetpos.x) == Mathf.FloorToInt(transform.position.x))
        {
       
            targetpos = new Vector2(Random.Range(-8.0f, 8.0f), transform.position.y);
            Debug.Log(targetpos.x);
        }
        
        if(transform.position.x>targetpos.x)
        {
            transform.Translate(Vector2.right * Time.deltaTime *enemySpeed);
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime *enemySpeed);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger Entered");
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }

    }

}

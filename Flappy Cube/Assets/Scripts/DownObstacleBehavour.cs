using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownObstacleBehavour : MonoBehaviour
{
    public float MoveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.localScale.x);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }

    
}

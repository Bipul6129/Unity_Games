using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveNonRoll : MonoBehaviour
{
    public float speed = 15.0f;
    public float Minspeed = 5.0f;
    private bool isHeld = false;
    private float startTime;
    public float boostTime=2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)&& isHeld==false)
        {
            isHeld = true;
            startTime = Time.time;
        }
        if (Input.GetKey(KeyCode.D))
        {
            if(Time.time-startTime >= boostTime)
            {
                transform.Rotate(Vector3.back * Time.deltaTime * 50);
                transform.Translate(Vector3.up * Time.deltaTime * 0.6f);
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            else
            {
                transform.Translate(Vector3.right * Time.deltaTime * Minspeed);
            }
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            isHeld = false;
        }


        if (Input.GetKeyDown(KeyCode.A) && isHeld == false)
        {
            isHeld = true;
            startTime = Time.time;
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (Time.time - startTime >= boostTime)
            {
                transform.Rotate(Vector3.forward * Time.deltaTime * 50);
                transform.Translate(Vector3.up * Time.deltaTime * 0.6f);
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * Minspeed);
            }

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            isHeld = false;
        }
    }
}

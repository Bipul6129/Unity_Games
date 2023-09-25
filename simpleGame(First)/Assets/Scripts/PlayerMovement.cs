using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private bool isMoving;
    private float rollspeed = 9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (isMoving) return;
        if (Input.GetKey(KeyCode.D))
        {
            var anchor = transform.position + new Vector3(0.5f, -0.5f, 0f);
            var axis = Vector3.Cross(Vector3.left, Vector3.up);
            StartCoroutine(Roll(anchor, axis));
        }
        
    }

    IEnumerator Roll(Vector3 anchor,Vector3 axis)
    {
        isMoving = true;

        for(int i = 0; i < (90 / rollspeed); i++)
        {
            transform.RotateAround(anchor, axis, rollspeed);
            yield return new WaitForSeconds(0.01f);
        }

        isMoving = false;
    }
}

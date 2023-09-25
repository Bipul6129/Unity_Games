using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    public float jumpheight = 3.0f;
    private bool isJumping = false;
    public float fallspeed = 3.0f;
    private bool keypressed = false;
    private float targetLocation;
    private float playerOldPos;
    private int targetlocInt;
    private int playerposInt;
    public float jumpspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isJumping == false)
        {
            if (keypressed == false)
            {
                transform.Translate(Vector2.down * fallspeed * Time.deltaTime);
            }
            
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                targetLocation = transform.position.y+jumpheight;
                playerOldPos = transform.position.y;
                isJumping = true;
                keypressed = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                targetLocation = transform.position.y + jumpheight;
                playerOldPos = transform.position.y;
                isJumping = true;
                keypressed = true;
            }
            targetlocInt = Mathf.RoundToInt(targetLocation);
            playerposInt = Mathf.RoundToInt(transform.position.y);
            if(targetlocInt == playerposInt)
            {
                isJumping = false;
                keypressed = false;
            }
            else
            {
                transform.Translate(Vector2.up * Time.deltaTime * jumpspeed);
            }
            
        }

        
    }

    void ResetJump()
    {
        
    }
}

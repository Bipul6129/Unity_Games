using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject bullet;
    private bool fired = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)&&fired==false)
        {
            fired =true;
            Vector3 playerPos = new Vector3(transform.position.x,transform.position.y+0.5f,transform.position.z);
            Instantiate(bullet,playerPos,bullet.transform.rotation);
            Invoke("Resetfire",0.4f);
        }

    }

    void Resetfire()
    {
        fired = false;
    }
}

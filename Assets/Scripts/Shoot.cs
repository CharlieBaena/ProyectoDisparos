using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float cooldown = 2f;

    private float lastShootTime = 0;
    

    // Update is called once per frame
    void Update()
    {

        if (Time.time > lastShootTime + cooldown || lastShootTime == 0)
        {
            if (Input.GetKey("space"))
            {
                foreach (Transform child in transform)
                {
                    Instantiate(bullet, child.position, Quaternion.identity);
                }
                lastShootTime = Time.time;
            }
        }

    }
}


        /*Disparar pulsando todo el rato
         * if (Time.time > lastShootTime + cooldown || lastShootTime == 0)
        {
            if (Input.GetKeyDown("space"))
            {
                foreach (Transform child in transform)
                {
                    Instantiate(bullet, child.position, Quaternion.identity);
                }
                lastShootTime = Time.time;
            }
        }

    }*/
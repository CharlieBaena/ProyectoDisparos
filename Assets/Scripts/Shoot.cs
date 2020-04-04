using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float cooldown = 2f;

    private float lastShootTime = 0;
    private SoundEffect sE;
    private GameObject padreDisparos;

    private void Start()
    {
        sE = GetComponent<SoundEffect>();
        padreDisparos = GameObject.Find("DisparosYExplosiones");
    }


    // Update is called once per frame
    void Update()
    {

        GameObject shoot;
        if (!GetComponent<Vida>().isDead) {
            if (Time.time > lastShootTime + cooldown || lastShootTime == 0)
            {
                if (!gameObject.GetComponent<Movimiento>().isPlayer2)
                {
                    if (Input.GetKey("space"))
                    {
                        sE.PlayShoot();
                        foreach (Transform child in transform)
                        {
                            shoot = Instantiate(bullet, child.position, Quaternion.identity);
                            shoot.transform.parent = padreDisparos.transform;
                        }
                        lastShootTime = Time.time;
                    }
                }
                else
                {
                    if (Input.GetKey("right ctrl"))
                    {
                        sE.PlayShoot();
                        foreach (Transform child in transform)
                        {
                            shoot = Instantiate(bullet, child.position, Quaternion.identity);
                            shoot.transform.parent = padreDisparos.transform;
                        }
                        lastShootTime = Time.time;
                    }
                }
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
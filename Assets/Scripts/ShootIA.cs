using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootIA : MonoBehaviour
{
    public GameObject bullet;
    public float cooldown = 2f;

    private float lastShootTime = 0;
    private SoundEffect sE;
    private GameObject padreDisparos;
    // Start is called before the first frame update
    void Start()
    {
        sE = GetComponent<SoundEffect>();
        padreDisparos = GameObject.Find("DisparosYExplosiones");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject shoot;
        if (!GetComponent<VidaIA>().isDead)
        {
            if (Time.time > lastShootTime + cooldown)
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

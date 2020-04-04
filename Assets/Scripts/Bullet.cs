using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]  // Para asignar automaticamente un rigidbody al objeto que le añadas este componente
public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float timeToDestroy = 2f;
    public bool disparoInvertido = false;
    public GameObject explosion;
    public int dmg;
    private Rigidbody2D myrb;

    private GameObject padreExplosion;

    // Start is called before the first frame update
    void Start()
    {
        padreExplosion = GameObject.Find("DisparosYExplosiones");
        myrb = gameObject.GetComponent<Rigidbody2D>();
        if(!disparoInvertido)
            myrb.velocity = Vector2.up * speed;
        else
            myrb.velocity = Vector2.down * speed;
        Destroy(gameObject, timeToDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("balaNormal"))
        {
            GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
            exp.transform.parent = padreExplosion.transform;
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("balaEnorme"))
        {
            if (!collision.CompareTag("balaNormal"))
            {
                GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
                exp.transform.parent = padreExplosion.transform;
                gameObject.SetActive(false);
            }
        }
    }


}

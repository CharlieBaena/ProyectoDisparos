using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]  // Para asignar automaticamente un rigidbody al objeto que le añadas este componente
public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float timeToDestroy = 2f;

    private Rigidbody2D myrb;

    // Start is called before the first frame update
    void Start()
    {
        myrb = gameObject.GetComponent<Rigidbody2D>();
        myrb.velocity = Vector2.up * speed;
        Destroy(gameObject, timeToDestroy);
    }


}

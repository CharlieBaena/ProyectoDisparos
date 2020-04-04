using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovimientoIA : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myrb;
    private Vector2 direction;
    private int valorX = 1;
    private float cambioAleatorio;
    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
        cambioAleatorio = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > cambioAleatorio)
        {
            valorX = -valorX;
            cambioAleatorio = Random.Range(1, 5);
            cambioAleatorio += Time.time;
        }

        if (!GetComponent<VidaIA>().isDead)
        {
            direction = new Vector2(valorX, 0);
        }
    }

    private void FixedUpdate()
    {
        MovePositionMovement();
    }

    void MovePositionMovement()
    {
        myrb.MovePosition((Vector2)transform.position + (speed * direction * Time.fixedDeltaTime));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paredDerecha"))
            valorX = -1;

        if (collision.gameObject.CompareTag("paredIzquierda"))
            valorX = 1;
    }

}

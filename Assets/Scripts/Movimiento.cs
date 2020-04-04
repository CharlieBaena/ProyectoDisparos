using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimiento : MonoBehaviour
{
    public float speed;
    public bool isPlayer2 = false;

    private Rigidbody2D myrb;
    private Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {
        myrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<Vida>().isDead)
        {
            if (!isPlayer2)
                direction = new Vector2(Input.GetAxis("HorizontalP1"), 0);
            else
                direction = new Vector2(Input.GetAxis("HorizontalP2"), 0);
        }
    }

    private void FixedUpdate()
    {
        //TranslateMovement();
        //AddingForceMovement();
        //VelocityMovement();
        MovePositionMovement();
    }

    void MovePositionMovement()
    {
        myrb.MovePosition((Vector2)transform.position + (speed * direction * Time.fixedDeltaTime));
    }

    void VelocityMovement()
    {
        myrb.velocity = direction * speed;
    }

    void AddingForceMovement()
    {
        myrb.AddForce(direction * speed);
    }

    void TranslateMovement()
    {
        transform.Translate(direction * speed * Time.fixedDeltaTime);
    }
}

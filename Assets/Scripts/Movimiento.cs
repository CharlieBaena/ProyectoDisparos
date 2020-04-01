using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movimiento : MonoBehaviour
{
    public float speed;

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
        direction = new Vector2 (Input.GetAxis("Horizontal"), 0);
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

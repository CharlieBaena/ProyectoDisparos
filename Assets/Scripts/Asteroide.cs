using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    private Transform myPosition;
    public float speed;
    public float timeToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        myPosition = GetComponent<Transform>();
        Destroy(gameObject, timeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        myPosition.position = myPosition.position + (Vector3.left * speed * Time.deltaTime);
        myPosition.Rotate(new Vector3(0, 0, 1));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
    }
}

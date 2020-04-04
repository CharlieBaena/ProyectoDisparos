using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovFondo : MonoBehaviour
{
    private Material myMaterial;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset = myMaterial.mainTextureOffset + Vector2.left * speed * Time.deltaTime;  // --->(1,0) * 0.5 ....
    }
}

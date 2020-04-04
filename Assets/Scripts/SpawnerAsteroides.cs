using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroides : MonoBehaviour
{
    public GameObject prefab1, prefab2, prefab3, prefabmediano1, prefabmediano2, prefabmediano3, prefabGrande1, prefabGrande2, prefabGrande3;
    public float tiempoEntreSpawns, spawnRandomRange;

    private GameObject padreAsteroides;

    // Start is called before the first frame update
    void Start()
    {
        padreAsteroides = GameObject.Find("Asteroides");
        InvokeRepeating("SpawnAsteroideNormal", 0F, tiempoEntreSpawns);
        InvokeRepeating("SpawnAsteroideMediano", 0F, tiempoEntreSpawns+10);
        InvokeRepeating("SpawnAsteroideGrande", 0F, tiempoEntreSpawns+20);
    }

    void SpawnAsteroideNormal()
    {
        int random = Random.Range(0, 3);
        GameObject asteroide;

        Vector3 posicionVertical;

        posicionVertical.x = 0.0f;
        posicionVertical.y = Random.Range(-spawnRandomRange, +spawnRandomRange);
        posicionVertical.z = 0.0f;

        switch (random)
        {
            case 0:
                asteroide = Instantiate(prefab1, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;

            case 1:
                asteroide = Instantiate(prefab2, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;

            case 2:
                asteroide = Instantiate(prefab3, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;
        }


    }

    void SpawnAsteroideMediano()
    {
        int random = Random.Range(0, 3);
        GameObject asteroide;

        Vector3 posicionVertical;

        posicionVertical.x = 0.0f;
        posicionVertical.y = Random.Range(-spawnRandomRange, +spawnRandomRange);
        posicionVertical.z = 0.0f;

        switch (random)
        {
            case 0:
                asteroide = Instantiate(prefabmediano1, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;

            case 1:
                asteroide = Instantiate(prefabmediano2, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;

            case 2:
                asteroide = Instantiate(prefabmediano3, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;
        }
    }

    void SpawnAsteroideGrande()
    {
        int random = Random.Range(0, 3);
        GameObject asteroide;

        Vector3 posicionVertical;

        posicionVertical.x = 0.0f;
        posicionVertical.y = Random.Range(-spawnRandomRange+1, +spawnRandomRange-1);
        posicionVertical.z = 0.0f;

        switch (random)
        {
            case 0:
                asteroide = Instantiate(prefabGrande1, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;

            case 1:
                asteroide = Instantiate(prefabGrande2, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;

            case 2:
                asteroide = Instantiate(prefabGrande3, transform.position + posicionVertical, Quaternion.identity);
                asteroide.transform.parent = padreAsteroides.transform;
                break;
        }
    }
}

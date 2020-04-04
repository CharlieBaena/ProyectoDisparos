using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public int maxVidas = 50;
    public HealthBar hB;
    public Text gameOver;
    public GameObject tryAgainButton,ExitButton;

    [HideInInspector]
    public bool isDead;

    private int vidas;
    private SoundEffect sE;

    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        gameOver.gameObject.SetActive(false);
        tryAgainButton.gameObject.SetActive(false);
        vidas = maxVidas;
        hB.SetMaxHealth(maxVidas);
        //Time.timeScale = 1f;
        sE = GetComponent<SoundEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] players;
        if (vidas == 0)
        {
            players = GameObject.FindGameObjectsWithTag("Player");
            foreach(GameObject player in players)
            {
                player.GetComponent<Vida>().isDead = true;
            }
            //isDead = true;
            sE.PlayDead();
            //Time.timeScale = 0f;
            gameOver.gameObject.SetActive(true);
            tryAgainButton.gameObject.SetActive(true);
            ExitButton.gameObject.SetActive(true);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        TakeDamage(collision.gameObject.GetComponent<Bullet>().dmg);
    }

    void TakeDamage(int daño)
    {
        vidas -= daño;
        hB.setHealth(vidas);
        if (vidas < 0) vidas = 0;
    }
}

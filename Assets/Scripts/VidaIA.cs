using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaIA : MonoBehaviour
{
    public int maxVidas = 50;
    public HealthBar hB;
    public Text gameOver;
    public GameObject tryAgainButton, ExitButton;

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
        if (vidas == 0)
        { 
            isDead = true;
            sE.PlayDead();
            gameOver.gameObject.SetActive(true);
            tryAgainButton.gameObject.SetActive(true);
            ExitButton.gameObject.SetActive(true);
            //Time.timeScale = 0f;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Musica : MonoBehaviour
{
    public AudioClip menu, twoPlayers , vsIA;

    /* private static Musica instance = null;
     public static Musica Instance
     {
         get { return instance; }
     }
     void Awake()
     {
         print(gameObject.name);
         if (instance != null && instance != this)
         {
             Destroy(this.gameObject);
             return;
         }
         else
         {
             instance = this;
         }
         DontDestroyOnLoad(this.gameObject);
     }*/


    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        /*switch (SceneManager.GetActiveScene().name)
        {
            case "MenuPrincipal":
                GetComponent<AudioSource>().clip = menu;
                break;

            case "2Players":
                GetComponent<AudioSource>().clip = twoPlayers;
                break;

            case "VsIA":
                GetComponent<AudioSource>().clip = vsIA;
                break;


        }*/


        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        GetComponent<AudioSource>().Play();
    }

    private void Update()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "MenuPrincipal":
                if (GetComponent<AudioSource>().clip != menu)
                {
                    GetComponent<AudioSource>().clip = menu;
                    GetComponent<AudioSource>().Play();
                }
                break;

            case "2Players":
                if (GetComponent<AudioSource>().clip != twoPlayers)
                {
                    GetComponent<AudioSource>().clip = twoPlayers;
                    GetComponent<AudioSource>().Play();
                }
                break;

            case "VsIA":
                if (GetComponent<AudioSource>().clip != vsIA)
                {
                    GetComponent<AudioSource>().clip = vsIA;
                    GetComponent<AudioSource>().Play();
                }
                break;

        }

    }
}

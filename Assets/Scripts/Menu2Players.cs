using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu2Players : MonoBehaviour
{

    public void PlayAgain()
    {
        SceneManager.LoadScene("2Players");
    }

    public void PlayAgainIA()
    {
        SceneManager.LoadScene("VsIA");
    }
    public void Exit()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}

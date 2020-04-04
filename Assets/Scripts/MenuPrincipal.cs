using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update
    public void TwoPlayers()
    {
        SceneManager.LoadScene("2Players");
    }

    public void VsIA()
    {
        SceneManager.LoadScene("VsIA");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene("Desert");
    }

    public void quitgame()
    {
        Application.Quit();
    }
    
}

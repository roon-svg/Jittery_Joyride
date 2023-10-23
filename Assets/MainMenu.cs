using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Level 1");
        // In the line above, we add the scene of the game, the first level where the game begins.

    }
    
    public void Quitgame()
    {
        Application.Quit();
    }


}

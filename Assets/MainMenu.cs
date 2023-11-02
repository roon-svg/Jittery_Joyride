using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string targetlevel1;
    public void Loadgame()
    {
        SceneManager.LoadScene(targetlevel1);
        // In the line above, we add the scene of the game, the first level where the game begins.
        //Using this scene manager.load scene command, out first scene loads which is called "targetlevel1"

    }
    
    public void Quitgame()
    {
        Application.Quit();
        // Once game is created we will be able to quit it.
    }


}

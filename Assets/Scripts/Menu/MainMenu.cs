using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /**
     * Permets de démarrer le premier niveau
     */
    public void PlayStage1()
    {
        SceneManager.LoadScene("Level1");
    }

    /*
     * Permets de démarrer le deuxième niveau
     */
    public void PlayStage2()
    {
        SceneManager.LoadScene("Level2");
    }

    /*
     * Permets de quitter le jeu
     */
    public void Exit()
    {
        Application.Quit();
    }
    
}

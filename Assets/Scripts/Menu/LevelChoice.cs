using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelChoice : MonoBehaviour
{
    //Boutton
    public Button Stage2;

    /*
     * Permets de définir les restrictions pour définir si un bouton est activable ou non
     */
    public void restriction()
    {
        int score = FindObjectOfType<GameManager>().LoadScore();

        if(score > 19)
        {
            Stage2.interactable = true;
        }
    }
}

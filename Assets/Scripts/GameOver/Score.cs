using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{   
    //Les champs de texte
    public Text playerScore;
    public Text bestScore;

    //Les medailles
    public GameObject golddMedal;
    public GameObject silverMedal;
    public GameObject noMedal;

    //Les bouttons
    public GameObject playButton;


    /*
     * Permets de r�cup�rer la valeur des deux GameObjects de type Text
     * Permets d'activer la m�daille correspondant au score
     */
    public void Awake()
    {
        int score = FindObjectOfType<GameManager>().getScore();
        playerScore.text =score.ToString();

        int best = FindObjectOfType<GameManager>().LoadScore();
        bestScore.text = best.ToString();

        if(score > 19)
        {
            golddMedal.SetActive(true);
            silverMedal.SetActive(true);
            noMedal.SetActive(true);
        } else if(score > 9) {
            golddMedal.SetActive(true);
            silverMedal.SetActive(true);
            noMedal.SetActive(true);
        } else
        {
            golddMedal.SetActive(true);
            silverMedal.SetActive(true);
            noMedal.SetActive(true);
        }
    }

    /*
     * Permets de changer vers la sc�ne Menu
    */
    public void goToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    /*
     * Permets de changer vers la derni�re sc�ne utilis�e
     */
    public void goToGame()
    {
        string stage=FindObjectOfType<GameManager>().level;
        SceneManager.LoadScene(stage);
    }
}

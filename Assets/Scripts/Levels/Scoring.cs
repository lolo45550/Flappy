using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{   
    //Champ de texte (score affich?)
    public Text scoreText;

    //Variable du score stock?
    private int score = 0;

    /**
     * Permets de calculer et sauvegarder le score a chaque appel de la fonction
     */
    public void scoring()
    {
        score++;
        FindObjectOfType<GameManager>().setScore(score);
        scoreText.text = score.ToString();
    }
}

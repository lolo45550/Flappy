using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringLevel2 : MonoBehaviour
{
    //Champ de texte (score affiché)
    public Text scoreText;
    //Variable du score stocké
    private int score = 0;

    /**
     * Permets de calculer et sauvegarder le score a chaque appel de la fonction
     */
    public void scoring()
    {
        score = score + 2;
        FindObjectOfType<GameManager>().setScore(score);
        scoreText.text = score.ToString();
    }
}
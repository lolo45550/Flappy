using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BestScore : MonoBehaviour
{
    public Text textScore;
    public GameObject golddMedal;
    public GameObject silverMedal;
    public GameObject noMedal;

    public void medal()
    {
        int score = FindObjectOfType<GameManager>().LoadScore();
        textScore.text = score.ToString();


        if (score > 19)
        {
            golddMedal.SetActive(true);
            silverMedal.SetActive(false);
            noMedal.SetActive(false);
        }
        else if (score > 9)
        {
            golddMedal.SetActive(false);
            silverMedal.SetActive(true);
            noMedal.SetActive(false);
        }
        else
        {
            golddMedal.SetActive(false);
            silverMedal.SetActive(false);
            noMedal.SetActive(true);
        }
    }
}





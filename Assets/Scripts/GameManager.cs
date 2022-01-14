using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public string namePlayer ="player";
    private int score = 0;
    private int best_score;

    public string level;

    public void Awake()
    {
        
        score = 0;
        best_score = LoadScore();
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        Application.targetFrameRate = 60;

        Pause();
        Play();
    }

    public int getScore()
    {
        return score;
    }

    public void Play(){
        score = 0;
        Time.timeScale = 1f;
        MovePipe[] pipes = FindObjectsOfType<MovePipe>();
        for (int i =0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    

    public void Pause()
    {

        Time.timeScale = 0f;
        MovePipe[] pipes = FindObjectsOfType<MovePipe>();
        
    }

    public void setScore(int sc)
    {
        score = sc;
        Debug.Log(score.ToString());
    }


    public void birdDead()
    {
        string thislevel = SceneManager.GetActiveScene().name;
        level = thislevel;
        Debug.Log(level);
        SaveScore();
        SceneManager.LoadScene("GameOver");
    }

    public void SaveScore()
    {
        if (best_score < score)
        {
            SaveSystem.SaveScore(this);
            Debug.Log("+1");
        }
    }

    public int LoadScore()
    {
        PlayerData data = SaveSystem.LoadScore();

        string data_name = data.namePlayer;
        int data_score = data.score;


        return data_score;
}
    
}

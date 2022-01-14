using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string namePlayer;
    public int score;

    public PlayerData(GameManager gm)
    {
        namePlayer = gm.namePlayer;
        score = gm.getScore();
    }

    public PlayerData()
    {
        namePlayer = "player";
        score = 0;
    }
}

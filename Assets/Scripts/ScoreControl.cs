using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    string score;
    float timer;

    void Start()
    {
        InvokeRepeating("Timer", 0, 1);
    }

    void Timer() 
    {
        timer++;
        score = timer.ToString();
    }

    public string getScore()
    {
        string prefsScore = PlayerPrefs.GetString("Score");
        string newScore;

        if(prefsScore == "")
        {
            newScore = score;
        }
        else
        {
            newScore = score + ", " + prefsScore;
        }

        PlayerPrefs.SetString("Score", newScore);
        return score;
    }
}

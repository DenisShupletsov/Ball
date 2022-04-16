using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCanvasControl : MonoBehaviour
{
    [SerializeField] GameObject mainMenuCanvas;
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] Text scoreText;

    public void getScoreToCanvas() 
    {
        string score = PlayerPrefs.GetString("Score");

        if(score != "")
        {
            scoreText.text = score;
        }

        mainMenuCanvas.SetActive(false);
        scoreCanvas.SetActive(true);
    }

    public void backToMainMenu()
    {
        scoreCanvas.SetActive(false);
        mainMenuCanvas.SetActive(true);
    }
}

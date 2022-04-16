using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasControl : MonoBehaviour
{
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject failedCanvas;
    [SerializeField] Text scoreText;
    [SerializeField] ScoreControl scoreControl;
    [SerializeField] float endTimeScale = 0.1f;
    bool isUserFinish;

    void Start()
    {
        Finish.OnFinish.AddListener(onFinish);
        SphereControl.OnFall.AddListener(onFall);
    }

    void onFinish()
    {
        isUserFinish = true;
        scoreText.text = scoreControl.getScore();
        winCanvas.SetActive(true);

        slowmoTime();
    }

    void onFall()
    {
        if(!isUserFinish)
        {
            failedCanvas.SetActive(true);

            slowmoTime();
        }
    }

    void slowmoTime()
    {
        Time.timeScale = endTimeScale;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}

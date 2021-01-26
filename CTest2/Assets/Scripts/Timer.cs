using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private bool timerEnabled;
    private float elapsedTime;
    private TimeSpan timeLeft;
    private TimeSpan startTime = TimeSpan.FromSeconds(300);

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Time Left: 5:00.00";
        timerEnabled = false;

        //call BeginTimer() in a game controller script 
        //also call EndTimer() in game controller
        BeginTimer();
    }

    public void BeginTimer()
    {
        timerEnabled = true;
        elapsedTime = 0f;
        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerEnabled = false;
    }

    private IEnumerator UpdateTimer()
    {
        while(timerEnabled){
            elapsedTime += Time.deltaTime;
            //when timer goes negative, timer starts counting up. Use EndTimer()
            timeLeft = startTime.Subtract(TimeSpan.FromSeconds(elapsedTime));
            timerText.text = "Time Left: " + timeLeft.ToString("m':'ss'.'ff");

            yield return null;
        }
    }
}

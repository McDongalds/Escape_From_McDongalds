using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;

    public Text timerText;
    public bool timerEnabled;
    private float elapsedTime;
    public TimeSpan timePlaying;
    public float endTime;
    public string endTimeDisplay;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "Time: 00:00.00";
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
        endTimeDisplay = TimeSpan.FromSeconds(elapsedTime).ToString("m':'ss'.'ff");
    }

    private IEnumerator UpdateTimer()
    {
        while(timerEnabled){
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            timerText.text = "Time: " + timePlaying.ToString("m':'ss'.'ff");

            yield return null;
        }
    }
}

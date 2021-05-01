using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    private Timer timerScript;
    public GameManager gameManager;

    void Awake()
    {
        timerScript = GetComponent<Timer>();
    }

    void OnTriggerEnter()
    {
        gameManager.GameWon();
        timerScript.EndTimer();
    }
}

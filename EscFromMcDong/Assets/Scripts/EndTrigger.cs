using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Timer timerScript;
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.GameWon();
        timerScript.EndTimer();
    }
}

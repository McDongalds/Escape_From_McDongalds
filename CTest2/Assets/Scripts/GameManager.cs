using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private Timer timerScript;
    bool gameEnded = false; 
    public float restartDelay = 1f;
    public GameObject gameWonUI;
    public Text timeText;

    void Awake()
    {
        timerScript = GetComponent<Timer>();
    }

    public void GameWon()
    {
        gameWonUI.SetActive(true);
        timeText.text = "Completion Time: " + timerScript.timePlaying.ToString("m':'ss'.'ff");
    }
    
    public void EndGame()
    {
        if(!gameEnded)
        {
            gameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Timer timerScript;
    bool gameEnded = false; 
    public float restartDelay = 1f;
    public GameObject gameWonUI;
    public Text timeText;
    

    public void GameWon()
    {
        gameWonUI.SetActive(true);
        timerScript.EndTimer();
        timeText.text = "Completion Time: " + timerScript.endTimeDisplay;
        StartCoroutine(EndDelay());
    }

    private IEnumerator EndDelay()
    {
        yield return new WaitForSeconds(8.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
    public void EndGame()
    {
        if(!gameEnded)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

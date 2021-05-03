using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    AudioSource audioSource;
    public void Awake()
    {
        
        audioSource.volume = .1f;
        
        
    }

    public void ChangeVolume(float vol)
    {
        Debug.Log(vol);
    }

    public void PlayGame()
    {
        //loads the Scene with an index that is 1 greater than the current index
        //Menu scene index = 0, game scene index = 1. Can be scene in build settings menu.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //Will only work after build
        Application.Quit();
    }
}

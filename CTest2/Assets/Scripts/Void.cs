using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Void : MonoBehaviour
{
    public GameObject VoidCube;
    public GameManager gameManager;

    void OnTriggerEnter()
    {
        VoidCube.SetActive(true);
        StartCoroutine(VoidPlayer());
    }
    
    private IEnumerator VoidPlayer()
    {
        //play void audio
        yield return new WaitForSeconds(10);
        gameManager.EndGame();
    }
}

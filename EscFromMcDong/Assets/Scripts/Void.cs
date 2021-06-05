using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Void : MonoBehaviour
{
    public GameObject VoidCube;
    public GameManager gameManager;
    public AudioSource voidNoise;
    public AudioSource menuSong;

    void OnTriggerEnter()
    {
        VoidCube.SetActive(true);
        StartCoroutine(VoidPlayer());
    }
    
    private IEnumerator VoidPlayer()
    {
        menuSong.mute = true;
        voidNoise.volume = GlobalControl.Instance.Volume;
        voidNoise.Play();
        yield return new WaitForSeconds(10);
        gameManager.EndGame();
    }
}

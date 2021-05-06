using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTrigger : MonoBehaviour
{
    public GameObject quest;
    public ItemManager itemManager;
    public AudioSource audioSource;
    public AudioSource bullySong;
    bool bullyPlay = true;

    void OnTriggerEnter()
    {
        if(!(itemManager.gotToy && itemManager.gotNugget && itemManager.gotFries))
        {
            quest.SetActive(true);
            if (bullyPlay)
            {
                audioSource.mute = true;
                bullySong.volume = GlobalControl.Instance.Volume * .6f;
                bullySong.Play();
                bullyPlay = false;
            }
           
        }
    }
}

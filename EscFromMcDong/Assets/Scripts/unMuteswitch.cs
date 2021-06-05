using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unMuteswitch : MonoBehaviour
{
    public AudioSource menuSong;
    public AudioSource bullySong;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    void Start()
    {
        menuSong.mute = false;
        bullySong.mute = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchSongs()
    {
        
    }
}

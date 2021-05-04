using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public CharacterController playerController;
    public float ladderHeight = 10f;
    private bool onLadder;
    float cSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        onLadder = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ladder")
        {
            onLadder = !onLadder;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ladder")
        {
            onLadder = !onLadder;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (onLadder)
        {
            
            cSpeed += 10 + Time.deltaTime;
            Vector3 climb = new Vector3(0f, cSpeed, 0f);
            playerController.Move(climb * Time.deltaTime);
        }
        else
            cSpeed = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public Transform playerController;
    public float ladderHeight = 10f;
    private bool onLadder; 
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
            playerController.transform.position += Vector3.up * ladderHeight;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public CharacterController playerController;
    public float ladderHeight = 10f;
    private bool onLadder;
    float cSpeed = 0;
    public PlayerMovement playerReal;
    // Start is called before the first frame update
    void Start()
    {
        onLadder = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ladder" && playerController.transform.position.y < 40f)
        {
            onLadder = true;
            Debug.Log(playerReal.gravity);
            playerReal.changeGrav(0);
            playerReal.changeYSpeed(0);

        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Ladder")
        {
            onLadder = false;
            playerReal.changeGrav(-9.8f);
            playerReal.changeYSpeed(0);
        }
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (onLadder && playerController.transform.position.y < 58)
        {
            Vector3 climb = new Vector3(0f, 10f, 0f);
            playerController.Move(climb * Time.deltaTime);
        }

    }
}

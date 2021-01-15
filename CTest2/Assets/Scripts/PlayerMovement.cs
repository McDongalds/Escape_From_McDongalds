using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(playerSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, playerSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}

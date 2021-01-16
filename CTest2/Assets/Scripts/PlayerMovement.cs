using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed;
    public float smoothTime;
    float turnSmoothVelocity;
    public Transform cam;
    public float gravity = -9.8f;
    public float ySpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(h, 0f, v).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * playerSpeed * Time.deltaTime);

        }
        if (controller.isGrounded)
            ySpeed = 0;
        if (!controller.isGrounded)
        {
            ySpeed += gravity * Time.deltaTime;
            Vector3 vGrav = new Vector3(0f, ySpeed, 0f);
            controller.Move(vGrav * Time.deltaTime);
        }


    }
}
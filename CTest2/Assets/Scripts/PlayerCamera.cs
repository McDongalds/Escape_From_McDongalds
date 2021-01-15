using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;
    public float smoothing = 0.125f;
    public Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPosition = target.position + camOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothing);
        transform.position = smoothedPosition;
    }
}

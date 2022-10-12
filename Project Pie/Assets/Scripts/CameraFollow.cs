using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.625f;

    public Vector3 offset;

    void FixedUpdate()
    {
        // Camera Targeting
        Vector3 desiredPosition = target.position + offset;
        // Smoothed Camera via Lerp
        Vector3 smoothed = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = target.position + offset;

        transform.LookAt(target);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 myVelocity = Vector3.zero;
    public float mySpeed = 6f;

    public Rigidbody myRigidbody;
    public float myRayLength = 10f;
    private int myMaskingLayer;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        myMaskingLayer = LayerMask.GetMask("Floor");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        myVelocity.Set(horizontal, 0, vertical);

        myVelocity = myVelocity.normalized * mySpeed * Time.deltaTime;

        myRigidbody.MovePosition(myRigidbody.position + myVelocity);

        Turn();
    }

    public void Turn()
    {
        Ray CameraToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit floorHit;

        if(Physics.Raycast(CameraToMouse, out floorHit, myRayLength, myMaskingLayer))
        {
            Vector3 playerToMouse = floorHit.point - myRigidbody.position;

            playerToMouse.y = 0;

            Quaternion newRotation = Quaternion.LookRotation(playerToMouse);

        }


    } 
}

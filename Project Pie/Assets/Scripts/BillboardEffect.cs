using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardEffect : MonoBehaviour {
    [SerializeField] private BillboardType billboardType;

    [Header("Lock Rotation")]
    [SerializeField] private bool lockX;
    [SerializeField] private bool lockY;
    [SerializeField] private bool lockZ;

    private Vector3 orignalRotation;

    public enum BillboardType { LookAtCamera, CameraForward };

    private void Awake()
    {
        orignalRotation = transform.rotation.eulerAngles;
    }

    void LateUpdate()
    {
        switch(billboardType)
        {
            case BillboardType.LookAtCamera:
                transform.LookAt(Camera.main.transform.position, Vector3.up);
                break;
            case BillboardType.CameraForward:
                transform.forward= Camera.main.transform.forward;
                break;
                default: 
                break;
        }
        Vector3 rotation = transform.rotation.eulerAngles;
        if (lockX) { rotation.x = orignalRotation.x; }
        if (lockY) { rotation.y = orignalRotation.y; }
        if (lockZ) { rotation.z = orignalRotation.z; }
        transform.rotation = Quaternion.Euler(rotation);
    }
}

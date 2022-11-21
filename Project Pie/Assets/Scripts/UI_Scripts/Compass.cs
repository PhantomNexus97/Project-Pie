using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compass : MonoBehaviour
{
    public Transform Player;
    Vector3 CVector;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CVector.z = Player.eulerAngles.y;
        transform.localEulerAngles= CVector;

    }
}

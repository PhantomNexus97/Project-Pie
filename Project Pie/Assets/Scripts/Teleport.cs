using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform _teleportLocation;
    public GameObject _Player;

    private void OnTriggerEnter(Collider other)
    {
        _Player.transform.position= _teleportLocation.position;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoveryUI : MonoBehaviour
{
    public PlayerBehaviour _pb;

    [Header("Discovered Enemies Icons")]
    public GameObject FoundCheeseIcon;
    public GameObject FoundBreadIcon;
    public GameObject FoundButterIcon;

    [Header("Undiscovered Enemies Icons")]
    public GameObject HiddenCheeseIcon;
    public GameObject HiddenBreadIcon;
    public GameObject HiddenButterIcon;

    void Update()
    {
        
        if( _pb._foundCheeseEnemy == true)
        {
            FoundCheeseIcon.SetActive(true);
            HiddenCheeseIcon.SetActive(false);
        }
        else if(_pb._foundCheeseEnemy == false)
        {
            HiddenCheeseIcon.SetActive(true);
            FoundCheeseIcon.SetActive(false);
        }
        if (_pb._foundBreadEnemy == true)
        {
            FoundBreadIcon.SetActive(true);
            HiddenBreadIcon.SetActive(false);
        }
        else if (_pb._foundBreadEnemy == false)
        {
            HiddenBreadIcon.SetActive(true);
            FoundBreadIcon.SetActive(false);
        }
        if (_pb._foundButterEnemy == true)
        {
            FoundButterIcon.SetActive(true);
            HiddenButterIcon.SetActive(false);
        }
        else if (_pb._foundButterEnemy == false)
        {
            HiddenButterIcon.SetActive(true);
            FoundButterIcon.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{

    // Item number store
    public int cheese;
    public int butter;
    public int bread;


    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Cheese")
        {
            cheese = cheese + 1;
            //Debug must remove
            Debug.Log("Cheese Collected");
            Col.gameObject.SetActive(false);
        }

        if (Col.gameObject.tag == "Butter")
        {
            butter = butter + 1;
            //Debug must remove
            Debug.Log("Butter Collected");
            Col.gameObject.SetActive(false);
        }

        if (Col.gameObject.tag == "Bread")
        {
            bread = bread + 1;
            //Debug must remove
            Debug.Log("Bread Collected");
            Col.gameObject.SetActive(false);
        }
    }
}

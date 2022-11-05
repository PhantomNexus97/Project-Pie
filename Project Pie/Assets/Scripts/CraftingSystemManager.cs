using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystemManager : MonoBehaviour
{
    public GameObject CraftingUI;
    public GameObject CraftButtonON;
    public GameObject CraftButtonOff;

    public PlayerInventory inventory;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "_craftingBench")
        {
            Debug.Log("Entered crafting zone");
            CraftingUI.SetActive(true);
            
        }
    }

    public void CraftGrillCheese()
    {
        inventory._cheese -= 1;
        inventory._bread -= 1;
        inventory._butter -= 1;
        inventory.CraftGrilledCheese();
        Debug.Log("You have : " + inventory._grilledCheese + " Grilled Cheese Sandwiches");

    } 
    // Update is called once per frame
    void Update()
    {

        if (inventory._cheese <= 0 && inventory._bread <= 0 && inventory._butter <= 0)
        {
            Debug.Log("You cant make it");
            CraftButtonOff.SetActive(false);
        }
        if (inventory._cheese >= 1 && inventory._bread >= 1 && inventory._butter >= 1)
        {
                Debug.Log("You can make it!");
                CraftButtonON.SetActive(true);
        }

        
    }
}

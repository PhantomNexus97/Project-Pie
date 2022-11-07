using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InventoryUI : MonoBehaviour
{
    [Header("InventoryMenu")]
    public GameObject InventoryMenu;
    public PlayerInventory inventory;

    [Header("InventoryUI Amt Check")]
    public TextMeshProUGUI cheeseAmtUI;
    public TextMeshProUGUI butterAmtUI;
    public TextMeshProUGUI breadAmtUI;

    [Header("CraftingUI Amt Check")]
    public TextMeshProUGUI cheeseCAmtUI;
    public TextMeshProUGUI butterCAmtUI;
    public TextMeshProUGUI breadCAmtUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "_inventoryChest")
        {
            Debug.Log("Entered Inventory zone");
            InventoryMenu.SetActive(true);
            Time.timeScale = 0f;
            PauseScreen.GameIsPaused = true;

        }
    }


    // Update is called once per frame
    void Update()
    {
        cheeseCAmtUI.text = inventory._cheese.ToString();
        butterCAmtUI.text = inventory._butter.ToString();
        breadCAmtUI.text = inventory._bread.ToString();


    }

    public void ResumeTime()
    {

        Time.timeScale = 1f;
        PauseScreen.GameIsPaused = false;
    }

    public void PauseTime()
    {

        Time.timeScale = 0f;
        PauseScreen.GameIsPaused = true;
    }
}

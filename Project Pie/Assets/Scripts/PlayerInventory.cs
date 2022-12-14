using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class PlayerInventory : MonoBehaviour, IDataPersistence
{

    [Header("Picked Up Items")]
    // Item number store
    public int _cheese;
    public int _butter;
    public int _bread;
    [Header("Crafted Items")]
    //Crafted Items store
    public int _grilledCheese;


    [Header("InventoryUI Amt Check")]
    public TextMeshProUGUI cheeseAmtUI;
    public TextMeshProUGUI butterAmtUI;
    public TextMeshProUGUI breadAmtUI;

    [Header("Craft Amt Check")]
    public TextMeshProUGUI cheeseCraftAmtUI;
    public TextMeshProUGUI butterCraftAmtUI;
    public TextMeshProUGUI breadCraftAmtUI;



    [Header("CraftedItemUI Amt Check")]
    //Crafted Inventory items
    //public TextMeshProUGUI grilledCheeseAmtUI;

      

    PlayerInventory inventory;
 
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "HUB")
        {
            cheeseAmtUI.text = _cheese.ToString();
            butterAmtUI.text = _butter.ToString();
            breadAmtUI.text = _bread.ToString();

            cheeseCraftAmtUI.text = _cheese.ToString();
            butterCraftAmtUI.text = _butter.ToString();
            breadCraftAmtUI.text = _bread.ToString();
        }
        else
        {
            return;
        }
    }

    //Pick ups
    public void AddCheese()
    {
        _cheese += 1;
    }
    public void AddButter()
    {
        _butter += 1;
    }
    public void AddBread()
    {
        _bread += 1;
    }

    //Craftables
    public void CraftGrilledCheese()
    {
        _grilledCheese += 1;
    }


    public void LoadData(GameData data)
    {
        this._cheese = data._cheese;
        this._butter = data._butter;
        this._bread = data._bread;
        this._grilledCheese = data._grilledCheese;
    }

    public void SaveData(GameData data)
    {
        data._cheese = this._cheese;
        data._butter = this._butter;
        data._bread = this._bread;
        data._grilledCheese = this._grilledCheese;
    }


    void Update()
    {
        //grilledCheeseAmtUI.text = _grilledCheese.ToString();
    }



}

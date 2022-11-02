using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerInventory : MonoBehaviour, IDataPersistence
{


    // Item number store
    public int _cheese;
    public int _butter;
    public int _bread;


    public TextMeshProUGUI cheeseAmtUI;
    public TextMeshProUGUI butterAmtUI;
    public TextMeshProUGUI breadAmtUI;

    PlayerInventory inventory;



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


    public void LoadData(GameData data)
    {
        this._cheese = data._cheese;
        this._butter = data._butter;
        this._bread = data._bread;
    }

    public void SaveData(GameData data)
    {
        data._cheese = this._cheese;
        data._butter = this._butter;
        data._bread = this._bread;
    }


    void Update()
    {

        cheeseAmtUI.text = _cheese.ToString();
        butterAmtUI.text = _butter.ToString();
        breadAmtUI.text = _bread.ToString();
    }


}

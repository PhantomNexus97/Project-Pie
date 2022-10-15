using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IDataPersistence
{


    // Item number store
    public int _cheese;
    public int _butter;
    public int _bread;





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





}

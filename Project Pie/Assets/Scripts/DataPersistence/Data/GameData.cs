using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
 
{
    public int _cheese;
    public int _butter;
    public int _bread;
    public int _grilledCheese;


    //public Vector3 _PlayerPosition;
    public SerializableDictionary<string, bool> _itemsCollected;


    public GameData()
    {
        
        this._cheese = 0;
        this._butter = 0;
        this._bread = 0;
        this._grilledCheese = 0;


        //_PlayerPosition = Vector3.zero;
        _itemsCollected = new SerializableDictionary<string, bool>();

    }
}

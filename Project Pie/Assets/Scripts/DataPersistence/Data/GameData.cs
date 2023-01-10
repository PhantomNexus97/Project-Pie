using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
 
{

    public int _playerHealth;

    public int _cheese;
    public int _butter;
    public int _bread;
    public int _grilledCheese;

    public bool _foundCheeseEnemy, _foundButterEnemy, _foundBreadEnemy = false;


    //public Vector3 _PlayerPosition;
    public SerializableDictionary<string, bool> _itemsCollected;


    public GameData()
    {
        //Player Health Saving
        this._playerHealth = 200;
        //Items Collected
        this._cheese = 0;
        this._butter = 0;
        this._bread = 0;
        this._grilledCheese = 0;
        //Enemys found
        this._foundCheeseEnemy = false;
        this._foundButterEnemy = false;
        this._foundBreadEnemy = false;

        //_PlayerPosition = Vector3.zero;
        _itemsCollected = new SerializableDictionary<string, bool>();

    }
}

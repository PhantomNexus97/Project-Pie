using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour, IDataPersistence
{

    public static GameManager gameManager { get; private set; }
    //Player
    public UnitHealth _playerHealth = new UnitHealth(200, 200);

    public PlayerInventory _playerInventory;

   


    void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
  
    public void LoadData(GameData data)
    {
        this._playerHealth.Health = data._playerHealth;
    }

    public void SaveData(GameData data)
    {
        data._playerHealth = this._playerHealth.Health;
    }
    private void Update()
    {

    }



}

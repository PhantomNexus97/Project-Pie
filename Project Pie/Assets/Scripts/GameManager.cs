using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour 
{

    public static GameManager gameManager { get; private set; }
    //Player
    public UnitHealth _playerHealth = new UnitHealth(100, 100);

    public PlayerInventory _playerInventory;

    public GameObject _winScreen;
    public GameObject _CraftUI;

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

    private void Update()
    {
        if(_playerInventory._grilledCheese >= 1)
        {
            _winScreen.SetActive(true);
            _CraftUI.SetActive(false);

        }
    }



}

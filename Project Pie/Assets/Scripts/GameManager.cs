using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour 
{



    public static GameManager gameManager { get; private set; }
    //Player
    public UnitHealth _playerHealth = new UnitHealth(100, 100);
    //Enemy
    public UnitHealth _enemyCheeseHealth = new UnitHealth(100, 100);

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



}

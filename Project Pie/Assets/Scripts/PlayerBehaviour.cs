using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Weapon Data")]
    public RangedWeaponData weaponData;

    [Header("Game Over Screen")]
    public GameObject gameOverScreen;

    [Header("Health Bar")]
    public TextMeshProUGUI healthAmtUI;

    [Header("MeleeBox")]
    public GameObject MeleeBox;

    public PlayerInventory inventory;
    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            weaponData.isFiring = true;
;        }
        if (Input.GetMouseButtonUp(0))
        {
            weaponData.isFiring = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            MeleeBox.SetActive(true);
        }
        if (Input.GetMouseButtonUp(1))
        {
            MeleeBox.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            PlayerTakeDmg(10);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health);
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            PlayerHeal(10);
            Debug.Log("You have been healed to " + GameManager.gameManager._playerHealth.Health);
        }
        if (GameManager.gameManager._playerHealth.Health <= 0)
        {
            Destroy(this.gameObject);
            gameOverScreen.SetActive(true);
        }
        healthAmtUI.text = GameManager.gameManager._playerHealth.Health.ToString();


    }



    private void PlayerTakeDmg(int dmg)
    {
        GameManager.gameManager._playerHealth.DmgUnit(dmg);
    }
    private void PlayerHeal(int healing)
    {
        GameManager.gameManager._playerHealth.HealUnit(healing);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CheeseEnemy")
        {
            PlayerTakeDmg(3);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Cheese");

        }

        if (other.gameObject.tag == "BreadEnemy")
        {
            PlayerTakeDmg(3);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Bread");

        }

        if (other.gameObject.tag == "ButterEnemy")
        {
            PlayerTakeDmg(3);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Butter");

        }

    }

 
}

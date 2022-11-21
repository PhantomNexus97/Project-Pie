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

    [Header("Menu Bool")]
    public bool menuIsOpen = false;

    public PlayerInventory inventory;
    void Start()
    {
        
    }


    void Update()
    {
        if (menuIsOpen == true)
        {
            weaponData.isFiring = false;
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


    public void Firing()
    {    
        weaponData.isFiring = true;  
    }

    public void NotFiring()
    {
        weaponData.isFiring = false;
    }

    public void SwingMelee()
    {
        MeleeBox.SetActive(true);
    }

    public void StopMelee()
    {
        MeleeBox.SetActive(false);
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

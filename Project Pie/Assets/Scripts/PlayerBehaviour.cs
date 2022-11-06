using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public RangedWeaponData weaponData;

    public GameObject gameOverScreen;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerTakeDmg(10);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerHeal(10);
            Debug.Log("You have been healed to " + GameManager.gameManager._playerHealth.Health);
        }
        if (GameManager.gameManager._playerHealth.Health <= 0)
        {
            Destroy(this.gameObject);
            gameOverScreen.SetActive(true);
        }
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
            PlayerTakeDmg(10);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Cheese");

        }

        if (other.gameObject.tag == "BreadEnemy")
        {
            PlayerTakeDmg(10);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Bread");

        }

        if (other.gameObject.tag == "ButterEnemy")
        {
            PlayerTakeDmg(10);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Butter");

        }

    }

 
}

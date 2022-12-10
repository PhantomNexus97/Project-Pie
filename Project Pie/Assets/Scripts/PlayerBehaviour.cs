using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class PlayerBehaviour : MonoBehaviour
{


    [Header("Weapon Data")]
    public RangedWeaponData weaponData;
    private Animator animator;

    [Header("Game Over Screen")]
    public GameObject gameOverScreen;

    [Header("Health Bar")]
    public Image healthBar, ringHealthBar;
    public Image[] healthPoints;
    float lerpSpeed;


    [Header("MeleeBox")]
    public GameObject MeleeBox;

    [Header("Menu Bool")]
    public bool menuIsOpen = false;

    public PlayerInventory inventory;
    void Start()
    {
        animator = GetComponent<Animator>();
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

        HealthBarFiller();
        lerpSpeed = 3f * Time.deltaTime;


    }
    void HealthBarFiller()
    {
        //healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, (GameManager.gameManager._playerHealth.Health / GameManager.gameManager._playerHealth.MaxHealth), lerpSpeed);
        //ringHealthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, (GameManager.gameManager._playerHealth.Health / GameManager.gameManager._playerHealth.MaxHealth), lerpSpeed);

        for (int i = 0; i < healthPoints.Length; i++)
        {
            healthPoints[i].enabled = !DisplayHealthPoint(GameManager.gameManager._playerHealth.Health, i);
        }
    }

    bool DisplayHealthPoint(int _health, int pointNumber)
    {
        return ((pointNumber * 10) >= _health);
    }

    public void Damage(int damagePoints)
    {
        if (GameManager.gameManager._playerHealth.Health > 0)
            GameManager.gameManager._playerHealth.Health -= damagePoints;
    }
    public void Heal(int healingPoints)
    {
        if (GameManager.gameManager._playerHealth.Health < GameManager.gameManager._playerHealth.MaxHealth)
            GameManager.gameManager._playerHealth.Health += healingPoints;
    }
    public void Firing()
    {    
        weaponData.isFiring = true;
        animator.SetBool("IsShooting", true);
    }

    public void NotFiring()
    {
        weaponData.isFiring = false;
        animator.SetBool("IsShooting", false);
    }

    public void SwingMelee()
    {
        MeleeBox.SetActive(true);
        animator.SetBool("IsMelee", true);
    }

    public void StopMelee()
    {
        MeleeBox.SetActive(false);
        animator.SetBool("IsMelee", false);
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
            PlayerTakeDmg(5);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Cheese");

        }

        if (other.gameObject.tag == "BreadEnemy")
        {
            PlayerTakeDmg(5);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Bread");

        }

        if (other.gameObject.tag == "ButterEnemy")
        {
            PlayerTakeDmg(5);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by Butter");

        }
        if (other.gameObject.tag == "ButterBall")
        {
            PlayerTakeDmg(5);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by ButterBall");

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "MeleeDmgBox")
        {
            PlayerTakeDmg(5);
            Debug.Log("You have been damaged to " + GameManager.gameManager._playerHealth.Health + " by MeleeDmgBox");
        }
    }


}

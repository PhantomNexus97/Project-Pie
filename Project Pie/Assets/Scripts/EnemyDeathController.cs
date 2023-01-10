using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathController : MonoBehaviour
{
    public UnitHealth _enemyHealth = new UnitHealth(100, 100);

    public GameObject Collectable;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ToastBullet")
        {
            EnemyTakeDmg(10);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MeleeWeapon")
        {
            EnemyTakeDmg(20);
            Debug.Log("Hit");
        }
    }
    private void EnemyTakeDmg(int dmg)
    {
        _enemyHealth.DmgUnit(dmg);
        Debug.Log("Damaged to " + _enemyHealth.Health);
    }

    void SpawnOjectCollectable()
    {
        GameObject newObject = Instantiate(Collectable, transform.position, transform.rotation);
        newObject.SetActive(true);
        
    }

    private void Update()
    {
        if (_enemyHealth.Health <= 0)
        {
            Destroy(this.gameObject);
            SpawnOjectCollectable();

        }
    }

}

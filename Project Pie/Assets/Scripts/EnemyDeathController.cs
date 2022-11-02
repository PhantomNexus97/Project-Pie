using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathController : MonoBehaviour
{
    public UnitHealth _enemyHealth = new UnitHealth(100, 100);


    public GameObject Cheese;





    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ToastBullet")
        {
            EnemyTakeDmg(10);

        }
        else if (_enemyHealth.Health <= 0)
        {
            SpawnOjectCheese();
            Destroy(gameObject);
        }
    }
    private void EnemyTakeDmg(int dmg)
    {
        _enemyHealth.DmgUnit(dmg);
        Debug.Log("Cheese damaged to " + _enemyHealth.Health);
    }

    void SpawnOjectCheese()
    {
        GameObject newObject = Instantiate(Cheese);
        Instantiate(Cheese, transform.position, transform.rotation);
    }


}

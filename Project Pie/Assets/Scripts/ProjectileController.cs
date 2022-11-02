using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public float speed;
    public GameObject Cheese;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CheeseEnemy")
        {
            EnemyTakeDmg(10);

        }
        else if (GameManager.gameManager._enemyCheeseHealth.Health <= 0)
        {
            SpawnOjectCheese();
            Destroy(gameObject);
        }
    }


    private void EnemyTakeDmg(int dmg)
    {
        GameManager.gameManager._enemyCheeseHealth.DmgUnit(dmg);
        Debug.Log("Cheese damaged to " + GameManager.gameManager._enemyCheeseHealth.Health);
    }

    void SpawnOjectCheese()
    {
        GameObject newObject = Instantiate(Cheese);
        Instantiate(Cheese, transform.position, transform.rotation);
    }




}

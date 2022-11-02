using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RangedWeaponData : MonoBehaviour
{

    public bool isFiring;
    public ProjectileController bullet;
    public float bulletSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public Transform firePoint;

    void Update()
    {
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShots;
               ProjectileController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
               newBullet.speed = bulletSpeed;
            }
        }
        else
        {
            shotCounter = 0;
        }
    }

}

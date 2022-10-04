using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Shooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileSpawnPoint;

    private float nextFire = 6f;
    private float fireRate = 8f;

    public void ShootProjectile()
    {
        if (Time.time - nextFire > 1 / fireRate)
        {
            nextFire = Time.time;
            var enemyProjectile = Instantiate(projectile, projectileSpawnPoint.position, transform.rotation);
        }
    }
}

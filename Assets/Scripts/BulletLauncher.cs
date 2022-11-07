using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private Rigidbody projectilePrefab;
    [SerializeField] private float launchForce = 700f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LaunchProjectile();
        }
    }

    private void LaunchProjectile()
    {
        //Instantiate a new Bullet
        var projectileInstance = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        
        //Bullet launching force
        projectileInstance.AddForce(firePoint.up * launchForce);
    }
}

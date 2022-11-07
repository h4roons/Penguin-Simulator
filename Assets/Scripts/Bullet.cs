using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    private void Update()
    {
        //Destroy Bullet after 2 seconds of firing
        Destroy(gameObject, 2f);
        
        //Bullet movement
        float forwardSpeed = bulletSpeed * Time.deltaTime;
        transform.Translate(Vector3.up * forwardSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        //Enemies to take damage
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent)) //if enemy, get enemy component
        {
            enemyComponent.TakeDamage(20); //set damage value of each bullet
        }
        //Destroy bullet on collision
        Destroy(gameObject);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    [SerializeField] private float health, maxHealth = 100f; //Enemy health
    void Start()
    {
        health = maxHealth; //Reset health to max
        
        enemy = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        enemy.SetDestination(Player.position);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount; // 100 -> 90 -> 80... -> 0 = Enemy has died

        //Kill enemy after health reaches 0
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

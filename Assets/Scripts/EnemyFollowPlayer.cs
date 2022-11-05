using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowPlayer : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
}

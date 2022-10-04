using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Enemy_AI : MonoBehaviour
{
    Enemy_Shooting shootTarget;
    private Transform followTarget;
    private float withinRange = 30f;
    private NavMeshAgent agent;

    void Start()
    {
        followTarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
        shootTarget = GetComponent<Enemy_Shooting>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, followTarget.position);
        if (distance <= withinRange)
        {
            if(followTarget != null)
            {
                transform.LookAt(followTarget.transform.position);
                shootTarget.ShootProjectile();
                agent.SetDestination(followTarget.position);
            }
        }
    }
}
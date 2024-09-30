using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Behaviour : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private float speedEnemy;
    [SerializeField] private float lineOfSight;

    public Transform[] patrolPoints;
    public int targetPoint;

    private void Start()
    {
        targetPoint = 0;
    }

    private void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, patrolPoints[0], speedEnemy * Time.deltaTime);
        CheckTarget();
    }

    private void CheckTarget()
    {
        float distanceFromTarget = Vector2.Distance(transform.position, target.transform.position);
        Vector2 direction = target.transform.position - transform.position;

        //target's inside trigger zone
        if (distanceFromTarget < lineOfSight)
        {
            
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lineOfSight);
    }
}

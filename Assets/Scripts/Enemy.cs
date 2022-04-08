using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent ennemiAgent;

    private void Awake()
    {
        ennemiAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ennemiAgent.destination = Objectif.targetPos;
    }

    public float getActualRemainingDistanceEstimate(NavMeshAgent agent)
    {
        Vector3[] pc = agent.path.corners;
        float totalDistance = 0f;
        foreach (Vector3 corner in pc)
        {
            totalDistance += corner.magnitude;
        }

        return totalDistance;

    }
}

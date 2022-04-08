using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Nightshade : MonoBehaviour
{
    private NavMeshAgent ennemiAgent;

    private void Awake()
    {
        ennemiAgent = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ennemiAgent.destination = Objectif.targetPos;
    }
}

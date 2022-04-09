using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent ennemiAgent;

    public float health = 100;

    public int moneyGame = 50;

    private void Awake()
    {
        ennemiAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += moneyGame;
        PlayerStats.Mort++;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ennemiAgent.destination = Objectif.targetPos;
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        End();
    }

    public void End()
    {
        // Dire au game manager que le chateau perd des pv
        PlayerStats.Lives--;

        // Detruire l'ennemi
        Destroy(gameObject);
    }


}

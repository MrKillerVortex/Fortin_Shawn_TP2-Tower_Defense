using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent ennemiAgent;
    Animator animator;

    public float startHealth = 100;
    public float health;
    public int moneyGame = 50;

    public Image healthBar;

    private void Awake()
    {
        ennemiAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        health = startHealth;
        animator = GetComponent<Animator>();
    }

    public void TakeDamage(float amount)
    {
        //Prend les dégats des bullets qui va additionner les dégats sur l'ennemi, jusqu'à sa mort.
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Quand un ennemi meurt, on donne un certain montant d'argent 
        // et on met plus un dans la mort des ennemis.
        PlayerStats.Money += moneyGame;
        PlayerStats.Mort++;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ennemiAgent.destination = Objectif.targetPos;

        var navArea = new NavMeshHit();

        // l'ennemi agent vérifie sur quelle zone il se trouve
        ennemiAgent.SamplePathPosition(-1, 0.0f, out navArea);

        // S'il ne se trouve pas sur la zone "Walkable", l'ennemi flotte
        if (navArea.mask != 1) // navArea.mask est de type 'integer'
            animator.SetBool("isFloating", true);
        else
            animator.SetBool("isFloating", false);

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

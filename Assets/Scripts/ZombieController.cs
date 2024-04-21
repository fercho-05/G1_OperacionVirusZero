using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    [SerializeField]
    float minChaseDistance;

    [SerializeField]
    float attackDistance;

    [SerializeField]
    float damage;

    [SerializeField]
    Animator animator;

    GameObject player; // Cambiado de target a player

    public float distanceToPlayer;
    NavMeshAgent navAgent;

    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        // Buscar el objeto del jugador al inicio
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            // Actualizar la distancia al jugador
            distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

            if (distanceToPlayer <= minChaseDistance)
            {
                ChasePlayer();
                if (distanceToPlayer <= attackDistance)
                {
                    AttackPlayer();
                }
            }
            else
            {
                StopChasing();
            }
        }
    }

    void ChasePlayer()
    {
        //navAgent.SetDestination(player.transform.position);
        animator.SetBool("IsWalking", true);
        animator.SetBool("IsAttacking", false);
    }

    void StopChasing()
    {
        animator.SetBool("IsWalking", false);
        animator.SetBool("IsAttacking", false);
    }

    void AttackPlayer()
    {
        //navAgent.SetDestination(transform.position); // Detenerse al atacar
        animator.SetBool("IsAttacking", true);
    }
}

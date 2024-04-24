using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    Transform target;

    //Distancia minima
    [SerializeField]
    float _minDistanceToAttack;

    //Control de daño de los Agentes
    float _damageTimer;

    NavMeshAgent _navAgent;

    Animator _animator;

    private void Awake()
    {
        _navAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        _damageTimer -= Time.deltaTime;

        _animator.SetBool("Walk", false);

        if (distance <= 10.0) //Buscar al jugador solo cuando este se acerque
        {
            _navAgent.SetDestination(target.position); //Buscar al jugador
            _animator.SetBool("Walk", true); //Iniciar caminata


            if (distance <= _minDistanceToAttack) //Hacer daño cuando ya esté cerca del jugador
            {
                //Control de tiempo al ataque del agente para que no dañe tan seguido
                if (_damageTimer <= 0.0F)
                {
                    _damageTimer = 5.0F; //Hace daño cada 5 segundos
                    
                    //PlayerHealthController playerHealthController = target.GetComponent<PlayerHealthController>();

                    //if (playerHealthController != null)
                    //{
                    //    playerHealthController.TakeDamage(5.0F);

                    //}
                }
            }

        }
    }
}

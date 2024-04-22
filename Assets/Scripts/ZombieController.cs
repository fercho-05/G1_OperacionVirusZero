using UnityEngine;
using UnityEngine.AI;

public class ZombieController : MonoBehaviour
{
    public float minChaseDistance = 20f;
    public float attackDistance = 3f;
    public string targetTag = "Player";
    public float distanceToTarget;

    private GameObject target;
    private NavMeshAgent navAgent;
    private Animator animator;
    private bool isAttacking;

    private void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        target = FindObjectByLayer(targetTag);
    }

    private GameObject FindObjectByLayer(string layerName)
    {
        GameObject[] objects = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objects)
        {
            if (obj.layer == LayerMask.NameToLayer(layerName))
            {
                return obj;
            }
        }
        return null;
    }

    private void Update()
    {
        if (target != null)
        {
            target = FindObjectByLayer(targetTag);
            distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

            if (distanceToTarget <= minChaseDistance)
            {
                ChaseOrAttackTarget();
            }
            else
            {
                StopChasing();
            }
        }
    }

    private void ChaseOrAttackTarget()
    {
        if (distanceToTarget <= attackDistance)
        {
            AttackTarget();
        }
        else
        {
            ChaseTarget();
        }
    }

    private void ChaseTarget()
    {
        navAgent.SetDestination(target.transform.position);
        animator.SetBool("IsWalking", true);
        animator.SetBool("IsAttacking", false);
    }

    private void StopChasing()
    {
        navAgent.ResetPath();
        animator.SetBool("IsWalking", false);
        animator.SetBool("IsAttacking", false);
    }

    private void AttackTarget()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            navAgent.ResetPath();
            animator.SetBool("IsAttacking", true);
        }
    }

    public void FinishAttack()
    {
        isAttacking = false;
    }
}

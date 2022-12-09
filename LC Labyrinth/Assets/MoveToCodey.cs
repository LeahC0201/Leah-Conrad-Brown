using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToCodey : MonoBehaviour
{
    private Animator animator;
    public NavMeshAgent agent2;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        agent2 = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent2.destination = Player.transform.position;
        if (agent2.hasPath)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}

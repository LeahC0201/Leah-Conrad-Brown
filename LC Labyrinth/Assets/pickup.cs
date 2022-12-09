using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pickup : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform goal2;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("goal"))
        {
            Destroy(other.gameObject);
            agent.destination = goal2.position;
        }
    }
}

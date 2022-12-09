using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;

    private void FixedUpdate()
    {
        if(transform.position.x <= -8 + transform.localScale.x / 2)
        {
            
        }
        if(transform.position.x >= 8 - transform.localScale.x / 2)
        {
            
        }
    }
}

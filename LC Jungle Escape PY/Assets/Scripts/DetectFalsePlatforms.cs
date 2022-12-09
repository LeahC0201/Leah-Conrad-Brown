using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    bool hit;

    void Update()
    {
        hit = Physics.Raycast(transform.position, transform.forward, 4f, 1 << 8);
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        if (hit)
        {
            Debug.LogWarning("Be Careful!");
        }
        else
        {
            Debug.Log("All clear!");
        }
    }
}

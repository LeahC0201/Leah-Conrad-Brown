using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportantThingy : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(door);
            Destroy(other.gameObject);
        }
    }
}

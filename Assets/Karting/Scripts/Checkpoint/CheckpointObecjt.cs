using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CheckpointObecjt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CheckpointManager a = other.GetComponent<CheckpointManager>();
        if (a != null)
        {
            a.instance.ultimochecpoint = transform;
        }
        
    }
}

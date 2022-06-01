using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public Transform ultimochecpoint;
    public CheckpointManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

}  

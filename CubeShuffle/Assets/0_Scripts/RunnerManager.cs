using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerManager : RunnerBaseManager
{

    void Start()
    {

    }


    void Update()
    {
        HandleMovement();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PositiveGate"))
        {
            IncreaseCubeNumber();
        }
        else if (other.gameObject.CompareTag("NegativeGate"))
        {
            DecreaseCubeNumber();
        }
    }

    protected override void IncreaseCubeNumber()
    {
        throw new System.NotImplementedException();
    }

    protected override void DecreaseCubeNumber()
    {
        throw new System.NotImplementedException();
    }

}

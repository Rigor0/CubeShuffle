using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerManager : RunnerBaseManager
{
    ObjectPooler objectPooler;

    void Start()
    {
        objectPooler = ObjectPooler.instance;
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
        objectPooler.GetPooledObject("Cube", Vector3.zero);
    }

    protected override void DecreaseCubeNumber()
    {
        throw new System.NotImplementedException();
    }

}

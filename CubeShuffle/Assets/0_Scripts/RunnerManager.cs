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

     protected override void DecreaseCubeNumber()
    {
        throw new System.NotImplementedException();
    }

    protected override void IncreaseCubeNumber()
    {
        throw new System.NotImplementedException();
    }
}

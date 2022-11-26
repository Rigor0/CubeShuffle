using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerManager : RunnerBaseManager
{
    ObjectPooler objectPooler;
    GateManager gateManager;
    private int gateNumber;
    public int rightTruckNumberIndex = 0;
    public int leftTruckNumberIndex = 1;

    void Start()
    {
        objectPooler = ObjectPooler.instance;
        gateManager = GateManager.instance;
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
        
        if (this.gameObject.CompareTag("RightTruck"))
        {
            gateNumber = gateManager.randomGatePositiveNumberHolder[rightTruckNumberIndex];
            for (int i = 0; i < gateNumber; i++)
            {
                GameObject obj = objectPooler.GetPooledObject("Cube", new Vector3(0, 5, 0));
                obj.transform.SetParent(transform);
                
            }
            rightTruckNumberIndex += 2;
        }
        else if (this.gameObject.CompareTag("LeftTruck"))
        {
            gateNumber = gateManager.randomGatePositiveNumberHolder[leftTruckNumberIndex];
            for (int i = 0; i < gateNumber; i++)
            {
                GameObject obj = objectPooler.GetPooledObject("Cube", new Vector3(0, 5, 0));
                obj.transform.SetParent(transform);
                
            }
            leftTruckNumberIndex += 2;
        }
    }

    protected override void DecreaseCubeNumber()
    {
        Debug.Log("Sa");
    }

}

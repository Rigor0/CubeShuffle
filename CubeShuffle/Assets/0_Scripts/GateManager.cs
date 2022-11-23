using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gates functionality.
///
/// Takes care of:
///     - calculating the random numbers of gates
/// <summary>

public class GateManager : GateManagerBase
{
    public static GateManager instance { get;private set; }
    private void Awake() 
    {
         instance = this;
    }
    void Start()
    {
        RandomGateNumber();
    }

    protected override int GetGateNumber()
    {
        return gateNumber;
    }

    protected override void RandomGateNumber()
    {
        switch (gateType)
        {
            case GateType.PositiveGate:
                gateNumber = Random.Range(2, 10);
                gateNumberText.text = gateNumber.ToString();
                break;

            case GateType.NegativeGate:
                gateNumber = Random.Range(-2, 10);
                gateNumberText.text = gateNumber.ToString();
                break;
        }
    }
}

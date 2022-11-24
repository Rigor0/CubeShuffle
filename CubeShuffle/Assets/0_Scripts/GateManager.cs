using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Gates functionality.
///
/// Takes care of:
///     - calculating the random numbers of gates
/// <summary>

public class GateManager : GateManagerBase
{
    #region Singleton
    public static GateManager instance { get; private set; }
    private void OnEnable()
    {
        instance = this;
    }
    #endregion

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
                gateNumberText.text = "+" + gateNumber.ToString();
                //GetTotalGateNumSum(gateNumber);
                Debug.Log(gateNumber);
                break;

            case GateType.NegativeGate:
                gateNumber = Random.Range(-2, 10);
                gateNumberText.text = "-" + gateNumber.ToString();
                break;
        }
    }

   /*protected override int GetTotalGateNumSum(int positiveNumber)
    {
        for (int i = 0; i <numOfGate; i++)
        {
            gateNumber += gateNumber;
        }

        return gateNumber;
    }*/
}

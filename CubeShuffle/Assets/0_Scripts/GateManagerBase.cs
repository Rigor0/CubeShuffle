using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Gates variables and functionalities
///
/// Takes care of:
///     - keeping the variables and functionalities of gates
/// <summary>
public abstract class GateManagerBase : MonoBehaviour
{
    [SerializeField] public TMP_Text gateNumberText;
    [SerializeField] protected enum GateType
    {
        PositiveGate,
        NegativeGate
    }

    [SerializeField] protected GateType gateType;
    [SerializeField] protected int gateNumber;
    [SerializeField] protected int numOfGate;


    protected abstract int GetGateNumber();
    protected abstract void RandomGateNumber();
    //protected abstract int GetTotalGateNumSum(int positiveNumber);


}

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
    [SerializeField] protected virtual TMP_Text gateNumberText { get; set; }
    [SerializeField] protected enum GateType
    {
        PositiveGate,
        NegativeGate
    }

    [SerializeField] protected GateType gateType;
    [SerializeField] protected int gateNumber;

    protected abstract int GetGateNumber();
    protected abstract void RandomGateNumber();


}

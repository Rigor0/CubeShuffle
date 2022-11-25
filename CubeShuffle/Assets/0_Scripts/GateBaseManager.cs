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
public abstract class GateBaseManager : MonoBehaviour
{
    [SerializeField] public TMP_Text gateNumberText;
    [SerializeField] protected List<GameObject> gates;
    [SerializeField] protected int gateNumber;

    protected abstract int GetGateNumber();
    protected abstract void RandomGateNumber();
}

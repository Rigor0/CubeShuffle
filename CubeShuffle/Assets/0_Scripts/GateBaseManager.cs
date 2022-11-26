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
    public List<int> randomGatePositiveNumberHolder;
    public List<int> randomGateNegativeNumberHolder;
    [SerializeField] public TMP_Text gateNumberText;
    [SerializeField] protected List<GameObject> gates;
    [SerializeField] public int gateNumber;

    //public abstract int GetGateNumber(int upgradedGateNumber);
    protected abstract void RandomGateNumber();
}

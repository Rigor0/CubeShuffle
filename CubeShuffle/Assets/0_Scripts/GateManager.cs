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

public class GateManager : GateBaseManager
{
    #region Singleton
    public static GateManager instance { get; private set; }
    private void OnEnable()
    {
        instance = this;
    }
    #endregion

    void Awake()
    {
        RandomGateNumber();
    }

    protected override int GetGateNumber()
    {
        return gateNumber;
    }

    protected override void RandomGateNumber()
    {
        foreach (var gate in gates)
        {
            if (gate.CompareTag("PositiveGate"))
            {
                gateNumber = Random.Range(2, 10);
                gateNumberText = gate.transform.Find("GreenGradient/GateNumberText").GetComponent<TMP_Text>();
                gateNumberText.text = "+" + gateNumber.ToString();
            }
            else if (gate.CompareTag("NegativeGate"))
            {
                gateNumber = Random.Range(-2, -10);
                gateNumberText = gate.transform.Find("RedGradient/GateNumberText").GetComponent<TMP_Text>();
                gateNumberText.text = gateNumber.ToString();
            }  
        }
    }

}

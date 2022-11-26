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

    /*public override int GetGateNumber(int upgradedGateNumber)
    {
        return upgradedGateNumber;
    }*/

    protected override void RandomGateNumber()
    {
        foreach (var gate in gates)
        {
            
            if (gate.CompareTag("PositiveGate"))
            {
                gateNumber = Random.Range(2, 10);
                randomGatePositiveNumberHolder.Add(gateNumber);
                gateNumberText = gate.transform.Find("GreenGradient/GateNumberText").GetComponent<TMP_Text>();
                gateNumberText.text = "+" + gateNumber.ToString();
            }
            else if (gate.CompareTag("NegativeGate"))
            {
                gateNumber = Random.Range(-2, -10);
                randomGateNegativeNumberHolder.Add(gateNumber);
                gateNumberText = gate.transform.Find("RedGradient/GateNumberText").GetComponent<TMP_Text>();
                gateNumberText.text = gateNumber.ToString();
            }  
        }
    }
}

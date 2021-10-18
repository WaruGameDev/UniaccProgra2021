using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickGainMoney : MonoBehaviour
{
    public int moneyToGain = 1;
    private void OnMouseDown()
    {
        //MoneyManager.money += moneyToGain;
        MoneyManager.instance.AddMoney(moneyToGain);
    }
}

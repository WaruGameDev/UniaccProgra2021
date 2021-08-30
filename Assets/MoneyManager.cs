using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    //public static int money;
    public static MoneyManager instance;
    public TextMeshProUGUI textMoney;
    public int money;
    public Transform esmeralda;
    public float esmeraldaX, esmeraldaY, esmeraldaZ;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");        
        float x = PlayerPrefs.GetFloat("EsmX");
        float y = PlayerPrefs.GetFloat("EsmY");
        float z = PlayerPrefs.GetFloat("EsmZ");

        if(x ==0 && y ==0 && z == 0)
        {
            //no hacemos nada y guardamos posición
            
            SavePositionEsmeralda();
        }
        else
        {
            esmeralda.position = new Vector3(x, y, z);
        }
        Debug.Log(x + " " + y + " " + z);
        
    }
    private void Update()
    {
        textMoney.text = money.ToString();
    }
    public void AddMoney(int moneyToGain)
    {
        money += moneyToGain;

        DataManager.SaveMoney(money);
        SavePositionEsmeralda();
    }
    public void SavePositionEsmeralda()
    {
        DataManager.SavePositionEsmeralda(esmeralda.position.x, 
            esmeralda.position.y, esmeralda.position.z);
    }
    public void ResetSave()
    {
        PlayerPrefs.DeleteAll();
    }
}

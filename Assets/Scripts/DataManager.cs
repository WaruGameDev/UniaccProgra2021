using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //public static int dataMoney;
    //public static float esmeraldaX, esmeraldaY, esmeraldaZ;

    public static void SaveMoney(int dataMoney)
    {
        PlayerPrefs.SetInt("Money", dataMoney);
    }
    public static void SavePositionEsmeralda(float a, float b, float c)
    {
        PlayerPrefs.SetFloat("EsmX", a);
        PlayerPrefs.SetFloat("EsmY", b);
        PlayerPrefs.SetFloat("Esmz", c);
    }


}

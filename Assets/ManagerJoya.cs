using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerJoya : MonoBehaviour
{
    public enum JOYAS
    {
        DIAMANTE, RUBI, ESMERALDA
    }
    public JOYAS joya = JOYAS.DIAMANTE;
    public SpriteRenderer sp;
    public Sprite diamante, esmeralda, rubi;
    public int joyaInt;
    
    public void ChangeJoya()
    {
        //switch(joya)
        //{
        //    case JOYAS.DIAMANTE:
        //        sp.sprite = diamante;
        //        break;
        //    case JOYAS.ESMERALDA:
        //        sp.sprite = esmeralda;
        //        break;
        //    case JOYAS.RUBI:
        //        sp.sprite = rubi;
        //        break;
        //}
        switch(joyaInt)
        {
            case 0:
                sp.sprite = diamante;
                break;
            case 1:
                sp.sprite = esmeralda;
                break;
            case 2:
                sp.sprite = rubi;
                break;
        }
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            ChangeJoya();
        }
    }
}

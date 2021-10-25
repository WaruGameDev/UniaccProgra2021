using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuesta : MonoBehaviour
{
    public bool isCorrect;

    public void Responder()
    {
        if(isCorrect)
        {
            QuestionManager.instance.correctas++;
        }
        else
        {
            QuestionManager.instance.incorrectas++;
        }
        QuestionManager.instance.NextQuestion();
    }

}

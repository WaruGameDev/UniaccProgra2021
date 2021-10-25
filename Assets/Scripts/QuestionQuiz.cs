using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Question", menuName = "QuizGame/Question", order = 0)]
public class QuestionQuiz : ScriptableObject
{
    public string pregunta;
    public int respuestaCorrectaIndex;
    public string[] respuestas;

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionManager : MonoBehaviour
{
    public List<QuestionQuiz> preguntaACargar;
    public static QuestionManager instance;
    public TextMeshProUGUI pregunta;
    public TextMeshProUGUI[] respuestas;
    public Respuesta[] respuestas_botones;
    public CanvasGroup panelFeedback;
    public TextMeshProUGUI feedbackText;
    public int correctas, incorrectas;
    public int index;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        panelFeedback.alpha = 0;
        panelFeedback.blocksRaycasts = false;
        panelFeedback.interactable = false;
        LoadQuestion();
    }

    public void LoadQuestion()
    {
        pregunta.text = preguntaACargar[index].pregunta;
        for (int i = 0; i < respuestas.Length; i++)
        {
            respuestas[i].text = preguntaACargar[index].respuestas[i];
        }
        respuestas_botones[preguntaACargar[index].respuestaCorrectaIndex].isCorrect = true;
    }
    public void NextQuestion()
    {
        index++;
        if(index >= preguntaACargar.Count)
        {
            Feedback();
        }
        else
        {
            LoadQuestion();
        }
        
    }
    public void Feedback()
    {
        panelFeedback.alpha = 1;
        panelFeedback.blocksRaycasts = true;
        panelFeedback.interactable = true;
        feedbackText.text = "Correctas: " + correctas + "\n" + "Incorrectas: " + incorrectas;
    }
}

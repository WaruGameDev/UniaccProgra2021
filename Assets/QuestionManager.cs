using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
    public int indexPreguntas;
    public int maxPreguntas = 1;
    //public int index;

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
        int preguntaRandom = Random.Range(0, preguntaACargar.Count);
        pregunta.text = preguntaACargar[preguntaRandom].pregunta;
        for (int i = 0; i < respuestas.Length; i++)
        {
            respuestas[i].text = preguntaACargar[preguntaRandom].respuestas[i];
        }
        respuestas_botones[preguntaACargar[preguntaRandom].respuestaCorrectaIndex].isCorrect = true;
        preguntaACargar.RemoveAt(preguntaRandom);
    }
    public void NextQuestion()
    {
        indexPreguntas++;
        if(indexPreguntas < maxPreguntas)
        {
            LoadQuestion();
        }
        else
        {
            Feedback();
        }
        //if(preguntaACargar.Count > 0)
        //{
        //    LoadQuestion();
        //}
        //else
        //{
        //    Feedback();
        //}
        //index++;
        //if(index >= preguntaACargar.Count)
        //{
        //    Feedback();
        //}
        //else
        //{
        //    LoadQuestion();
        //}
        
    }
    public void Feedback()
    {
        panelFeedback.alpha = 1;
        panelFeedback.blocksRaycasts = true;
        panelFeedback.interactable = true;
        feedbackText.text = "Correctas: " + correctas + "\n" + "Incorrectas: " + incorrectas;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("Quiz");
    }
}

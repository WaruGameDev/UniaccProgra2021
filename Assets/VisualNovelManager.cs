using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
[System.Serializable]
public class DialogueVisualNovel
{
    public string characterName;
    public string characterDialogue;
    public Sprite characterPortrait;
}

public class VisualNovelManager : MonoBehaviour
{
    public static VisualNovelManager instance;
    [Header("Dialogos y controlador")]
    public List<DialogueVisualNovel> dialogues;
    public int index = 0;
    [Header("Referencias canvas")]
    public TextMeshProUGUI nameCharacterText, dialogueCharacterText;
    public Image portrait;
    public RectTransform portraitPivot;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        portraitPivot.DOMoveY(20, 2).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
        ShowDialogue(dialogues[0]);
    }
    public void ShowDialogue(DialogueVisualNovel dialogue)
    {
        //portraitPivot.DOShakeScale(0.2f, new Vector3(0.2f, 0.2f, 0));
        nameCharacterText.text = dialogue.characterName;
        dialogueCharacterText.text = dialogue.characterDialogue;
        portrait.sprite = dialogue.characterPortrait;
    }
    public void AdvanceDialogue()
    {
        index++;
        if (index >= dialogues.Count)
        {
            index = 0;
        }
        else
        {
            ShowDialogue(dialogues[index]);
        }
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Avance", index);
    }
    public void Load()
    {
        index = PlayerPrefs.GetInt("Avance");
        ShowDialogue(dialogues[index]);
    }
}
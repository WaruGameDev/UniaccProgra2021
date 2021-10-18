using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Dialogue
{
    public string nameCharacter;
    public string dialogue;
    public Sprite portrait;
}

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;    
    public TextMeshProUGUI nameText, dialogueText;
    public Image portrait;

    private void Awake()
    {
        instance = this;
    }
    public void ShowDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.nameCharacter;
        dialogueText.text = dialogue.dialogue;
        portrait.sprite = dialogue.portrait;
    }
}

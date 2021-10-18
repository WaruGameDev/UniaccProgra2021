using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCharacter : MonoBehaviour
{
    public List<Dialogue> dialogues;
    public Quest quest;

    public void DialogueShow()
    {
        DialogueManager.instance.ShowDialogue(dialogues[(int)QuestManager.instance.GetQuestStatus(quest.nombreQuest)]);
    }
}


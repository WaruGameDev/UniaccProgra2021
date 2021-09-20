using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestChanger : MonoBehaviour
{
    public Quest.QUEST_STATUS requireStatus;

    public string questToChange;
    public Quest.QUEST_STATUS newQuestStatus;
    public UnityEvent onChangeQuest;
    // Start is called before the first frame update
    public void QuestChange()
    {
        if(QuestManager.instance.GetQuestStatus(questToChange) == requireStatus)
        {
            QuestManager.instance.SetQuestStatus(questToChange, newQuestStatus);
            onChangeQuest?.Invoke();
        }        
    }
}

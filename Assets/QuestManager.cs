using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Quest
{
    public string nombreQuest;
    public enum QUEST_STATUS
    {
        UNNASSIGNED, ASSIGNED, COMPLETE
    }
    public QUEST_STATUS qStatus;
}

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public List<Quest> quests;

    private void Awake()
    {
        instance = this;
    }
    
    public void SetQuestStatus(string questName, Quest.QUEST_STATUS newQuestStatus)
    {
        foreach(Quest q in quests)
        {
            if(q.nombreQuest == questName)
            {
                q.qStatus = newQuestStatus;
            }
        }
    }

    public Quest.QUEST_STATUS GetQuestStatus(string questName)
    {
        Quest.QUEST_STATUS questStatus = Quest.QUEST_STATUS.UNNASSIGNED;
        foreach(Quest q in quests)
        {
            if(q.nombreQuest == questName)
            {
                questStatus = q.qStatus;
            }
        }
        return questStatus;
    }

    public void ResetQuest()
    {
        foreach (Quest q in quests)
        {
            q.qStatus = Quest.QUEST_STATUS.UNNASSIGNED;
        }
    }

    //private void Update()
    //{
    //    if(Input.GetButtonDown("Jump"))
    //    {
    //        //SetQuestStatus("Rubi", Quest.QUEST_STATUS.ASSIGNED);

           
        
    //    }
    //}
}

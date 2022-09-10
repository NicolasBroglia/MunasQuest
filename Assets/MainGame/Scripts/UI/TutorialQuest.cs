using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialQuest : MonoBehaviour
{
    public GameObject questMenu;
    public GameObject enemyQuest;
    void Update()
    {
        QuestGoal();
    }

    private void QuestGoal()
    {
            CompleteQuest();  
    }
    private void CompleteQuest()
    {
        questMenu.SetActive(false);
    }

}

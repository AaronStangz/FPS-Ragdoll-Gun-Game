using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    public GameObject mainQuestTab;
    public GameObject dailyQuestTab;
    public GameObject selectTab;

    public bool InselectTab;


    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && InselectTab == false) 
        {
            mainQuestTab.SetActive(false);
            dailyQuestTab.SetActive(false);
            selectTab.SetActive(true);
        }
    }

    public void MainQuest()
    {
        InselectTab = false;
        mainQuestTab.SetActive(true);
        dailyQuestTab.SetActive(false);
        selectTab.SetActive(false);
    }
    public void DailyQuest()
    {
        InselectTab = false;
        mainQuestTab.SetActive(false);
        dailyQuestTab.SetActive(true);
        selectTab.SetActive(false);
    }
}

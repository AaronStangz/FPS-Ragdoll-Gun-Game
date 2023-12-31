using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainQuest : MonoBehaviour
{
    ItemManager ItemManager;
    public GameObject MainMenu;
    public bool Sidebar;

    public GameObject[] Sidebars;

    [Header("Pages")]
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;

    [Header("Quest")]
    public GameObject QuestNum1;
    public GameObject QuestNum1Start;
    public GameObject QuestNum2Lock;
    [Header("")]
    public GameObject QuestNum2;
    public GameObject QuestNum2Start;
    public GameObject QuestNum3Lock;
    [Header("")]
    public GameObject QuestNum3;
    public GameObject QuestNum3Start;
    public GameObject QuestNum4Lock;
    [Header("")]
    public GameObject QuestNum5Lock;

    void Start()
    {
        ItemManager = gameObject.GetComponent<ItemManager>();
    }
    void Update()
    {

    }

    public void ToggleSideBar(int indexToEnable)
    {
        for (int i = 0; i < Sidebars.Length; i++) 
        {
            Sidebars[i].SetActive(indexToEnable == i);
        }
    }

    ///////////// Quest: 1 //////////
    public void QuestNum_1_Start()
    {
        MainMenu.SetActive(false);
        QuestNum1.SetActive(true);
    }
    public void QuestNum_1_End()
    {
        Cursor.lockState = CursorLockMode.None;
        QuestNum1.SetActive(false);
        MainMenu.SetActive(true);
        Destroy(QuestNum1Start);
        QuestNum2Lock.SetActive(false);
    }


    ///////////// Quest: 2 //////////
    public void QuestNum_2_Start()
    {
        MainMenu.SetActive(false);
        QuestNum2.SetActive(true);
    }
    public void QuestNum_2_End()
    {
        Cursor.lockState = CursorLockMode.None;
        QuestNum2.SetActive(false);
        MainMenu.SetActive(true);
        Destroy(QuestNum2Start);
       // QuestNum3Lock.SetActive(false);
    }


    ///////////// Quest: 3 //////////
    public void QuestNum_3_Start()
    {
        MainMenu.SetActive(false);
        QuestNum2.SetActive(true);
    }
    public void QuestNum_3_End()
    {
        Cursor.lockState = CursorLockMode.None;
        QuestNum3.SetActive(false);
        MainMenu.SetActive(true);
        QuestNum4Lock.SetActive(false);
    }


    ///////////// Quest: 4 //////////
    public void QuestNum_4_Start()
    {

    }
    public void QuestNum_4_End()
    {
        //QuestNum5Lock.SetActive(false);
    }
}

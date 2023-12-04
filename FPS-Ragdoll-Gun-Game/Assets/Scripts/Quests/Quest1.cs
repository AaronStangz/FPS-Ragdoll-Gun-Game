using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1 : MonoBehaviour
{
    MainQuest mainQuest;
    ItemManager itemManager;
    public GameObject mainManger;

    public GameObject questNum1;
    public GameObject player;
    public Transform playerSpawn;


    public int HowMuchNeedToFind;

    void Start()
    {
        itemManager = mainManger.GetComponent<ItemManager>();
        mainQuest = mainManger.GetComponent<MainQuest>();

        if (questNum1 != null)
        {
            player.transform.position = playerSpawn.transform.position;
            player.SetActive(true);
        }
    }

    void Update()
    {
        if(questNum1 != null)
        {
            if (itemManager.files == HowMuchNeedToFind)
            {
                itemManager.files -= HowMuchNeedToFind;
                player.SetActive(false);
                mainQuest.QuestNum_1_End();
            }
        }
    }
}

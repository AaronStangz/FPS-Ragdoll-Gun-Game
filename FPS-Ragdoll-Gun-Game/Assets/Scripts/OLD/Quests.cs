using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    ItemManager ItemManager;

    public GameObject homeBase;
    public GameObject player;

    [Header("Quests")]
    public GameObject quest1;
    public GameObject spawnPointQuest1;
    public GameObject quest2;
    void Start()
    {
        ItemManager = player.GetComponent<ItemManager>();
    }

    public void StartQuest1()
    {
        homeBase.SetActive(false);
        quest1.SetActive(true);
        player.transform.position = spawnPointQuest1.transform.position;
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIManger : MonoBehaviour
{
    [Header("BackGroundTabs")]
    public GameObject questTab;
    public GameObject mapTab;
    public GameObject armoryTab;
    public GameObject upgradesTab;
    public GameObject researchTab;
    public GameObject lockerTab;
    public GameObject shopTab;

    [Header("Tabs")]
    public GameObject questTabUI;
    public GameObject mapTabUI;
    public GameObject armoryTabUI;
    public GameObject upgradesTabUI;
    public GameObject researchTabUI;
    public GameObject lockerTabUI;
    public GameObject shopTabUI;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void QuestTab()
    {
        questTab.SetActive(true);
        mapTab.SetActive(false);
        armoryTab.SetActive(false);
        upgradesTab.SetActive(false);
        researchTab.SetActive(false);
        lockerTab.SetActive(false);
        shopTab.SetActive(false);
        questTabUI.SetActive(true);
        mapTabUI.SetActive(false);
        armoryTabUI.SetActive(false);
        upgradesTabUI.SetActive(false);
        researchTabUI.SetActive(false);
        lockerTabUI.SetActive(false);
        shopTabUI.SetActive(false);
    }
    public void MapTab()
    {
        questTab.SetActive(false);
        mapTab.SetActive(true);
        armoryTab.SetActive(false);
        upgradesTab.SetActive(false);
        researchTab.SetActive(false);
        lockerTab.SetActive(false);
        shopTab.SetActive(false);
        questTabUI.SetActive(false);
        mapTabUI.SetActive(true);
        armoryTabUI.SetActive(false);
        upgradesTabUI.SetActive(false);
        researchTabUI.SetActive(false);
        lockerTabUI.SetActive(false);
        shopTabUI.SetActive(false);
    }

    public void ArmoryTab()
    {
        questTab.SetActive(false);
        mapTab.SetActive(false);
        armoryTab.SetActive(true);
        upgradesTab.SetActive(false);
        researchTab.SetActive(false);
        lockerTab.SetActive(false);
        shopTab.SetActive(false);
        questTabUI.SetActive(false);
        mapTabUI.SetActive(false);
        armoryTabUI.SetActive(true);
        upgradesTabUI.SetActive(false);
        researchTabUI.SetActive(false);
        lockerTabUI.SetActive(false);
        shopTabUI.SetActive(false);
    }

    public void UpgradesTab()
    {
        questTab.SetActive(false);
        mapTab.SetActive(false);
        armoryTab.SetActive(false);
        upgradesTab.SetActive(true);
        researchTab.SetActive(false);
        lockerTab.SetActive(false);
        shopTab.SetActive(false);
        questTabUI.SetActive(false);
        mapTabUI.SetActive(false);
        armoryTabUI.SetActive(false);
        upgradesTabUI.SetActive(true);
        researchTabUI.SetActive(false);
        lockerTabUI.SetActive(false);
        shopTabUI.SetActive(false);
    }
    public void ResearchTab()
    {
        questTab.SetActive(false);
        mapTab.SetActive(false);
        armoryTab.SetActive(false);
        upgradesTab.SetActive(false);
        researchTab.SetActive(true);
        shopTab.SetActive(false);
        lockerTab.SetActive(false);
        questTabUI.SetActive(false);
        mapTabUI.SetActive(false);
        armoryTabUI.SetActive(false);
        upgradesTabUI.SetActive(false);
        researchTabUI.SetActive(true);
        lockerTabUI.SetActive(false);
        shopTabUI.SetActive(false);
    }
    public void LockerTab()
    {
        questTab.SetActive(false);
        mapTab.SetActive(false);
        armoryTab.SetActive(false);
        upgradesTab.SetActive(false);
        researchTab.SetActive(false);
        lockerTab.SetActive(true);
        shopTab.SetActive(false);
        questTabUI.SetActive(false);
        mapTabUI.SetActive(false);
        armoryTabUI.SetActive(false);
        upgradesTabUI.SetActive(false);
        researchTabUI.SetActive(false);
        lockerTabUI.SetActive(true);
        shopTabUI.SetActive(false);
    }
    public void ShopTab()
    {
        questTab.SetActive(false);
        mapTab.SetActive(false);
        armoryTab.SetActive(false);
        upgradesTab.SetActive(false);
        researchTab.SetActive(false);
        lockerTab.SetActive(false);
        shopTab.SetActive(true);
        questTabUI.SetActive(false);
        mapTabUI.SetActive(false);
        armoryTabUI.SetActive(false);
        upgradesTabUI.SetActive(false);
        researchTabUI.SetActive(false);
        lockerTabUI.SetActive(false);
        shopTabUI.SetActive(true);
    }
}

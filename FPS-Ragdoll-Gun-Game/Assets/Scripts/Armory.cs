using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armory : MonoBehaviour
{
    ItemManager ItemManager;
    public GameObject mainManger;

    [Header("Pages")]
    public GameObject riflesTab;
    public GameObject handgunsTab;
    public GameObject shotsgunsTab;
    public GameObject machineGunsTab;
    public GameObject bluePrintsTab;


    void Start()
    {
        ItemManager = mainManger.GetComponent<ItemManager>();
    }

    void Update()
    {
        
    }

    public void Rifles()
    {
        riflesTab.SetActive(true);
        handgunsTab.SetActive(false);
        shotsgunsTab.SetActive(false);
        machineGunsTab.SetActive(false);
        bluePrintsTab.SetActive(false);
    }

    public void Handguns()
    {
        riflesTab.SetActive(false);
        handgunsTab.SetActive(true);
        shotsgunsTab.SetActive(false);
        machineGunsTab.SetActive(false);
        bluePrintsTab.SetActive(false);
    }
    public void Shotsguns()
    {
        riflesTab.SetActive(false);
        handgunsTab.SetActive(false);
        shotsgunsTab.SetActive(true);
        machineGunsTab.SetActive(false);
        bluePrintsTab.SetActive(false);
    }

    public void MachineGuns()
    {
        riflesTab.SetActive(false);
        handgunsTab.SetActive(false);
        shotsgunsTab.SetActive(false);
        machineGunsTab.SetActive(true);
        bluePrintsTab.SetActive(false);
    }

    public void BluePrints()
    {
        riflesTab.SetActive(false);
        handgunsTab.SetActive(false);
        shotsgunsTab.SetActive(false);
        machineGunsTab.SetActive(false);
        bluePrintsTab.SetActive(true);
    }
}

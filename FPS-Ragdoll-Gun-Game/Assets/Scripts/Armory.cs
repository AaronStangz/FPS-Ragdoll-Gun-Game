using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armory : MonoBehaviour
{
    ItemManager ItemManager;
    public GameObject mainManger;

    public bool StorgeRifles;
    public bool StorgeHandguns;
    public bool StorgeShotsguns;
    public bool StorgeMachineGuns;

    [Header("Pages")]
    public GameObject riflesTab;
    public GameObject handgunsTab;
    public GameObject shotsgunsTab;
    public GameObject machineGunsTab;
    public GameObject bluePrintsTab;

    [Header("GunObject")]
    public GameObject assaultrifleObject;
    public GameObject eclipseEnforcerObject;
    public GameObject phantomwhisperObject;
    [Header("")]
    public GameObject pistoleObjectObject;
    public GameObject cobaltSentinelObject;
    public GameObject zenithDefenderObject;
    [Header("")]
    public GameObject doublebarrelObject;
    public GameObject emberGuardianObject;
    public GameObject phoenixWingObject;
    [Header("")]
    public GameObject submachineObject;
    public GameObject nebulaHavocObject;
    public GameObject emberWarbringerObject;


    void Start()
    {
        ItemManager = mainManger.GetComponent<ItemManager>();
    }

    void Update()
    {
        if (StorgeRifles == false)
        {
            assaultrifleObject.SetActive(false);
            eclipseEnforcerObject.SetActive(false);
            phantomwhisperObject.SetActive(false);
        }

        if (StorgeHandguns == false)
        {
            pistoleObjectObject.SetActive(false);
            cobaltSentinelObject.SetActive(false);
            zenithDefenderObject.SetActive(false);
        }

        if (StorgeShotsguns == false)
        {
            doublebarrelObject.SetActive(false);
            emberGuardianObject.SetActive(false);
            phoenixWingObject.SetActive(false);
        }

        if (StorgeMachineGuns == false)
        {
            submachineObject.SetActive(false);
            nebulaHavocObject.SetActive(false);
            emberWarbringerObject.SetActive(false);
        }
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

    public void assaultrifleStorge()
    {
        Debug.Log("Selceted");
        StorgeRifles = false;
        StorgeRifles = true;
        assaultrifleObject.SetActive(true);
    }
    public void eclipseEnforcerStorge()
    {
        StorgeRifles = false;
        Debug.Log("Selceted");
        StorgeRifles = true;
        eclipseEnforcerObject.SetActive(true);
    }
    public void phantomwhisperStorge()
    {
        StorgeRifles = false;
        Debug.Log("Selceted");
        StorgeRifles = true;
        phantomwhisperObject.SetActive(true);
    }

    public void pistoleStorge()
    {
        StorgeHandguns = false;
        Debug.Log("Selceted");
        StorgeHandguns = true;
        pistoleObjectObject.SetActive(true);
    }
    public void cobaltSentinelStorge()
    {
        StorgeHandguns = false;
        Debug.Log("Selceted");
        StorgeHandguns = true;
        cobaltSentinelObject.SetActive(true);
    }
    public void zenithDefenderStorge()
    {
        StorgeHandguns = false;
        Debug.Log("Selceted");
        StorgeHandguns = true;
        zenithDefenderObject.SetActive(true);
    }

    public void doublebarrelStorge()
    {
        StorgeShotsguns = false;
        Debug.Log("Selceted");
        StorgeShotsguns = true;
        doublebarrelObject.SetActive(true);
    }
    public void emberGuardianStorge()
    {
        StorgeShotsguns = false;
        Debug.Log("Selceted");
        StorgeShotsguns = true;
        emberGuardianObject.SetActive(true);
    }
    public void phoenixWingStorge()
    {
        StorgeShotsguns = false;
        Debug.Log("Selceted");
        StorgeShotsguns = true;
        phoenixWingObject.SetActive(true);
    }

    public void submachineStorge()
    {
        StorgeMachineGuns = false;
        Debug.Log("Selceted");
        StorgeMachineGuns = true;
        submachineObject.SetActive(true);
    }
    public void nebulaHavocStorge()
    {
        StorgeMachineGuns = false;
        Debug.Log("Selceted");
        StorgeMachineGuns = true;
        nebulaHavocObject.SetActive(true);
    }
    public void emberWarbringerStorge()
    {
        StorgeMachineGuns = false;
        Debug.Log("Selceted");
        StorgeMachineGuns = true;
        emberWarbringerObject.SetActive(true);
    }
}

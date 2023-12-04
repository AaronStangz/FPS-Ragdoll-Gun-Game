using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Research : MonoBehaviour
{
    ItemManager ItemManager;
    public GameObject mainManger;

    [Header("Pages")]
    public GameObject riflesTab;
    public GameObject handgunsTab;
    public GameObject shotsgunsTab;
    public GameObject machineGunsTab;
    public GameObject bluePrintsTab;

    [Header("GunPartsText")]
    public TMP_Text assaultriflePartsText;
    public TMP_Text eclipseEnforcerPartsText;
    public TMP_Text phantomwhisperPartsText;
    [Header("")]
    public TMP_Text pistolePartsText;
    public TMP_Text cobaltSentinelPartsText;
    public TMP_Text zenithDefenderPartsText;
    [Header("")]
    public TMP_Text doublebarrelPartsText;
    public TMP_Text emberGuardianPartsText;
    public TMP_Text phoenixWingPartsText;
    [Header("")]
    public TMP_Text submachinePartsText;
    public TMP_Text nebulaHavocPartsText;
    public TMP_Text emberWarbringerPartsText;

    [Header("GunLock")]
    public GameObject assaultrifleLock;
    public GameObject eclipseEnforcerLock;
    public GameObject phantomwhisperLock;
    [Header("")]
    public GameObject pistoleLock;
    public GameObject cobaltSentinelLock;
    public GameObject zenithDefenderLock;
    [Header("")]
    public GameObject doublebarrelLock;
    public GameObject emberGuardianLock;
    public GameObject phoenixWingLock;
    [Header("")]
    public GameObject submachineLock;
    public GameObject nebulaHavocLock;
    public GameObject emberWarbringerLock;

    void Start()
    {
        ItemManager = mainManger.GetComponent<ItemManager>();
    }

    void Update()
    {
        ResearchPartsTexts();
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

    public void ResearchPartsTexts()
    {
        assaultriflePartsText.text = "Parts: " + ItemManager.assaultrifleParts + " / " + ItemManager.assaultriflePartsNeeded + " ";
        eclipseEnforcerPartsText.text = "Parts: " + ItemManager.eclipseEnforcerParts + " / " + ItemManager.eclipseEnforcerPartsNeeded + " ";
        phantomwhisperPartsText.text = "Parts: " + ItemManager.phantomwhisperParts + " / " + ItemManager.phantomwhisperPartsNeeded + " ";

        pistolePartsText.text = "Parts: " + ItemManager.pistoleParts + " / " + ItemManager.pistolePartsNeeded + " ";
        cobaltSentinelPartsText.text = "Parts: " + ItemManager.cobaltSentinelParts + " / " + ItemManager.cobaltSentinelPartsNeeded + " ";
        zenithDefenderPartsText.text = "Parts: " + ItemManager.zenithDefenderParts + " / " + ItemManager.zenithDefenderPartsNeeded + " ";

        doublebarrelPartsText.text = "Parts: " + ItemManager.doublebarrelParts + " / " + ItemManager.doublebarrelPartsNeeded + " ";
        emberGuardianPartsText.text = "Parts: " + ItemManager.emberGuardianParts + " / " + ItemManager.emberGuardianPartsNeeded + " ";
        phoenixWingPartsText.text = "Parts: " + ItemManager.phoenixWingParts + " / " + ItemManager.phoenixWingPartsNeeded + " ";

        submachinePartsText.text = "Parts: " + ItemManager.submachineParts + " / " + ItemManager.submachinePartsNeeded + " ";
        nebulaHavocPartsText.text = "Parts: " + ItemManager.nebulaHavocParts + " / " + ItemManager.nebulaHavocPartsNeeded + " ";
        emberWarbringerPartsText.text = "Parts: " + ItemManager.emberWarbringerParts + " / " + ItemManager.emberWarbringerPartsNeeded + " ";
    }

    public void AssaultrifleLock()
    {
        if(ItemManager.assaultrifleParts >= ItemManager.assaultriflePartsNeeded)
        {
            Debug.Log("ReSearched");
            assaultrifleLock.SetActive(false);
            ItemManager.assaultrifleParts -= ItemManager.assaultriflePartsNeeded;
        }
    }

    public void EclipseEnforcerLock()
    {
        if (ItemManager.eclipseEnforcerParts >= ItemManager.eclipseEnforcerPartsNeeded)
        {
            Debug.Log("ReSearched");
            eclipseEnforcerLock.SetActive(false);
            ItemManager.eclipseEnforcerParts -= ItemManager.eclipseEnforcerPartsNeeded;

        }
    }

    public void PhantomwhisperLock()
    {
        if (ItemManager.phantomwhisperParts >= ItemManager.phantomwhisperPartsNeeded)
        {
            Debug.Log("ReSearched");
            phantomwhisperLock.SetActive(false);
            ItemManager.phantomwhisperParts -= ItemManager.phantomwhisperPartsNeeded;

        }
    }
    public void PistoleLock()
    {
        if (ItemManager.pistoleParts >= ItemManager.pistolePartsNeeded)
        {
            Debug.Log("ReSearched");
            pistoleLock.SetActive(false);
            ItemManager.pistoleParts -= ItemManager.pistolePartsNeeded;

        }
    }
    public void CobaltSentinelLock()
    {
        if (ItemManager.cobaltSentinelParts >= ItemManager.cobaltSentinelPartsNeeded)
        {
            Debug.Log("ReSearched");
            cobaltSentinelLock.SetActive(false);
            ItemManager.cobaltSentinelParts -= ItemManager.cobaltSentinelPartsNeeded;

        }
    }
    public void ZenithDefenderLock()
    {
        if (ItemManager.zenithDefenderParts >= ItemManager.zenithDefenderPartsNeeded)
        {
            Debug.Log("ReSearched");
            zenithDefenderLock.SetActive(false);
            ItemManager.zenithDefenderParts -= ItemManager.zenithDefenderPartsNeeded;

        }
    }
    public void DoublebarrelLock()
    {
        if (ItemManager.doublebarrelParts >= ItemManager.doublebarrelPartsNeeded)
        {
            Debug.Log("ReSearched");
            doublebarrelLock.SetActive(false);
            ItemManager.doublebarrelParts -= ItemManager.doublebarrelPartsNeeded;

        }
    }
    public void EmberGuardianLock()
    {
        if (ItemManager.emberGuardianParts >= ItemManager.emberGuardianPartsNeeded)
        {
            Debug.Log("ReSearched");
            emberGuardianLock.SetActive(false);
            ItemManager.emberGuardianParts -= ItemManager.emberGuardianPartsNeeded;

        }
    }
    public void PhoenixWingLock()
    {
        if (ItemManager.phoenixWingParts >= ItemManager.phoenixWingPartsNeeded)
        {
            Debug.Log("ReSearched");
            phoenixWingLock.SetActive(false);
            ItemManager.phoenixWingParts -= ItemManager.phoenixWingPartsNeeded;

        }
    }
    public void SubmachineLock()
    {
        if (ItemManager.submachineParts >= ItemManager.submachinePartsNeeded)
        {
            Debug.Log("ReSearched");
            submachineLock.SetActive(false);
            ItemManager.submachineParts -= ItemManager.submachinePartsNeeded;

        }
    }
    public void NebulaHavocLock()
    {
        if (ItemManager.nebulaHavocParts >= ItemManager.nebulaHavocPartsNeeded)
        {
            Debug.Log("ReSearched");
            nebulaHavocLock.SetActive(false);
            ItemManager.nebulaHavocParts -= ItemManager.nebulaHavocPartsNeeded;

        }
    }
    public void EmberWarbringerLock()
    {
        if (ItemManager.emberWarbringerParts >= ItemManager.emberWarbringerPartsNeeded)
        {
            Debug.Log("ReSearched");
            emberWarbringerLock.SetActive(false);
            ItemManager.emberWarbringerParts -= ItemManager.emberWarbringerPartsNeeded;

        }
    }
}

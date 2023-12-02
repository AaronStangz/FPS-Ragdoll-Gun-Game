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

    [Header("GunParts")]
    public GameObject ar15PartsText;
    public GameObject ak47PartsText;
    public GameObject natoPartsText;
    public GameObject mCWPartsText;
    public GameObject aUGPartsText;
    public GameObject m14PartsText;

    public GameObject desertEaglePartsText;
    public GameObject mK23PartsText;
    public GameObject ocelotsRevolverPartsText;
    public GameObject mK23SocomPartsText;

    public GameObject leverActionPartsText;
    public GameObject tokarevPartsText;
    public GameObject doublebarrelPartsText;

    public GameObject m16PartsText;
    public GameObject m240BPartsText;
    public GameObject mp5PartsText;
    public GameObject cZBRENPartsText;
    public GameObject hkG36PartsText;

    [Header("GunLocks")]
    public GameObject ar15PartsLock;
    public GameObject ak47PartsLock;
    public GameObject natoPartsLock;
    public GameObject mCWPartsLock;
    public GameObject aUGPartsLock;
    public GameObject m14PartsLock;

    public GameObject desertEaglePartsLock;
    public GameObject mK23PartsLock;
    public GameObject ocelotsRevolverPartsLock;
    public GameObject mK23SocomPartsLock;

    public GameObject leverActionPartsLock;
    public GameObject tokarevPartsLock;
    public GameObject doublebarrelPartsLock;

    public GameObject m16PartsLock;
    public GameObject m240BPartsLock;
    public GameObject mp5PartsLock;
    public GameObject cZBRENPartsLock;
    public GameObject hkG36PartsLock;
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
        ar15PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.ar15Parts + " / " + ItemManager.ar15PartsNeeded + " ";
        ak47PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.ak47Parts + " / " + ItemManager.ak47PartsNeeded + " ";
        natoPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.natoParts + " / " + ItemManager.natoPartsNeeded + " ";
        mCWPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.mCWParts + " / " + ItemManager.mCWPartsNeeded + " ";
        aUGPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.aUGParts + " / " + ItemManager.aUGPartsNeeded + " ";
        m14PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.m14Parts + " / " + ItemManager.m14PartsNeeded + " ";
        desertEaglePartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.desertEagleParts + " / " + ItemManager.desertEaglePartsNeeded + " ";
        mK23PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.mK23Parts + " / " + ItemManager.mK23PartsNeeded + " ";
        ocelotsRevolverPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.ocelotsRevolverParts + " / " + ItemManager.ocelotsRevolverPartsNeeded + " ";
        mK23SocomPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.mK23SocomParts + " / " + ItemManager.mK23SocomPartsNeeded + " ";
        leverActionPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.leverActionParts + " / " + ItemManager.leverActionPartsNeeded + " ";
        tokarevPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.tokarevParts + " / " + ItemManager.tokarevPartsNeeded + " ";
        doublebarrelPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.doublebarrelParts + " / " + ItemManager.doublebarrelPartsNeeded + " ";
        m16PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.m16Parts + " / " + ItemManager.m16PartsNeeded + " ";
        m240BPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.m240BParts + " / " + ItemManager.m240BPartsNeeded + " ";
        mp5PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.mp5Parts + " / " + ItemManager.mp5PartsNeeded + " ";
        cZBRENPartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.cZBRENParts + " / " + ItemManager.cZBRENPartsNeeded + " ";
        hkG36PartsText.GetComponent<TextMeshProUGUI>().text = "Parts: " + ItemManager.hkG36Parts + " / " + ItemManager.hkG36PartsNeeded + " ";
    }

    public void AR15Lock()
    {
        Debug.Log("ReSearched");
        ar15PartsLock.SetActive(false);
        ItemManager.ar15Parts -= ItemManager.ar15PartsNeeded;
    }
    public void AK47Lock()
    {
        Debug.Log("ReSearched");
        ak47PartsLock.SetActive(false);
        ItemManager.ak47Parts -= ItemManager.ak47PartsNeeded;
    }
    public void NATOLock()
    {
        Debug.Log("ReSearched");
        natoPartsLock.SetActive(false);
        ItemManager.natoParts -= ItemManager.natoPartsNeeded;
    }
    public void MCWLock()
    {
        Debug.Log("ReSearched");
        mCWPartsLock.SetActive(false);
        ItemManager.mCWParts -= ItemManager.mCWPartsNeeded;
    }
    public void AUGLock()
    {
        Debug.Log("ReSearched");
        aUGPartsLock.SetActive(false);
        ItemManager.aUGParts -= ItemManager.aUGPartsNeeded;
    }
    public void M14Lock()
    {
        Debug.Log("ReSearched");
        m14PartsLock.SetActive(false);
        ItemManager.m14Parts -= ItemManager.m14PartsNeeded;
    }
    public void DesretEagleLock()
    {
        Debug.Log("ReSearched");
        desertEaglePartsLock.SetActive(false);
        ItemManager.desertEagleParts -= ItemManager.desertEaglePartsNeeded;
    }
    public void MK23Lock()
    {
        Debug.Log("ReSearched");
        mK23PartsLock.SetActive(false);
        ItemManager.mK23Parts -= ItemManager.mK23PartsNeeded;
    }
    public void OcelotsRevolverLock()
    {
        Debug.Log("ReSearched");
        ocelotsRevolverPartsLock.SetActive(false);
        ItemManager.ocelotsRevolverParts -= ItemManager.ocelotsRevolverPartsNeeded;
    }
    public void MK23SocomLock()
    {
        Debug.Log("ReSearched");
        mK23SocomPartsLock.SetActive(false);
        ItemManager.mK23SocomParts -= ItemManager.mK23SocomPartsNeeded;
    }
    public void LeverActionLock()
    {
        Debug.Log("ReSearched");
        leverActionPartsLock.SetActive(false);
        ItemManager.leverActionParts -= ItemManager.leverActionPartsNeeded;
    }
    public void TokarevLock()
    {
        Debug.Log("ReSearched");
        tokarevPartsLock.SetActive(false);
        ItemManager.tokarevPartsNeeded -= ItemManager.tokarevPartsNeeded;
    }
    public void doublebarrelLock()
    {
        Debug.Log("ReSearched");
        doublebarrelPartsLock.SetActive(false);
        ItemManager.doublebarrelParts -= ItemManager.doublebarrelPartsNeeded;
    }
    public void M16Lock()
    {
        Debug.Log("ReSearched");
        m16PartsLock.SetActive(false);
        ItemManager.m16Parts -= ItemManager.m16PartsNeeded;
    }
    public void M240BLock()
    {
        Debug.Log("ReSearched");
        m240BPartsLock.SetActive(false);
        ItemManager.m240BParts -= ItemManager.m240BPartsNeeded;
    }
    public void Mp5Lock()
    {
        Debug.Log("ReSearched");
        mp5PartsLock.SetActive(false);
        ItemManager.mp5Parts -= ItemManager.mp5PartsNeeded;
    }
    public void CZBREN()
    {
        Debug.Log("ReSearched");
        cZBRENPartsLock.SetActive(false);
        ItemManager.cZBRENParts -= ItemManager.cZBRENPartsNeeded;
    }
    public void HKG36()
    {
        Debug.Log("ReSearched");
        hkG36PartsLock.SetActive(false);
        ItemManager.hkG36Parts -= ItemManager.hkG36PartsNeeded;
    }
}

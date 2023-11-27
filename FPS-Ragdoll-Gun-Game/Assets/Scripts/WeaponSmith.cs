using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponSmith : MonoBehaviour
{
    Backpack backpack;
    ItemManager ItemManager;

    [SerializeField] private PlayerCam cam;
    [SerializeField] private PlayerMovement move;
    public GameObject player;

    public float OpenRange;
    public bool IsOpen = false;
    bool ResearchPageIsOpen = false;

    public GameObject UI;

    [Header("Pages")]
    public GameObject rifles;
    public GameObject handguns;
    public GameObject machineGuns;
    public GameObject research;

    [Header("LocksGun")]
    public GameObject AR15Lock;
    public GameObject AK47Lock;

    [Header("ResearchPage")]
    public GameObject ar15PartsText;
    public GameObject ak47PartsText;

    void Start()
    {
        ItemManager = player.GetComponent<ItemManager>();
        backpack = GetComponent<Backpack>();
    }

    void Update()
    {
        Escape();

        ResearchPartsTexts();

        if (IsOpen == false)
        {
            UI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (IsOpen == true)
        {
            UI.SetActive(true);
            cam.enabled = false;
            move.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void OpenMenu()
    {
        Debug.Log("OpennedMenu");
        IsOpen = true;
        UI.SetActive(true);
    }

    public void Rifles()
    {
        rifles.SetActive(true);
        handguns.SetActive(false);
        machineGuns.SetActive(false);
        research.SetActive(false);
    }

    public void Handguns()
    {
        handguns.SetActive(true);
        rifles.SetActive(false);
        machineGuns.SetActive(false);
        research.SetActive(false);
    }

    public void MachineGuns()
    {
        machineGuns.SetActive(true);
        handguns.SetActive(false);
        rifles.SetActive(false);
        research.SetActive(false);
    }

    public void Research()
    {
        ResearchPageIsOpen = true;
        machineGuns.SetActive(false);
        handguns.SetActive(false);
        rifles.SetActive(false);
        research.SetActive(true);
    }

    ////////// Researching //////////

    public void ResearchAr15()
    {
        if(ItemManager.ar15PartsNeeded <= ItemManager.ar15Parts)
        {
            Debug.Log("ReSearched");
            AR15Lock.SetActive(false);
            ItemManager.ar15Parts -= ItemManager.ar15PartsNeeded;
        }
    }

    public void ResearchAk47()
    {
        if (ItemManager.ak47PartsNeeded <= ItemManager.ak47Parts)
        {
            Debug.Log("ReSearched");
            AK47Lock.SetActive(false);
            ItemManager.ak47Parts -= ItemManager.ak47PartsNeeded;
        }
    }

    public void ResearchPartsTexts()
    {
        if(ResearchPageIsOpen == true)
        {
            ar15PartsText.GetComponent<TextMeshProUGUI>().text = "(Parts: " + ItemManager.ar15Parts + " / " + ItemManager.ar15PartsNeeded + " )";
            ak47PartsText.GetComponent<TextMeshProUGUI>().text = "(Parts: " + ItemManager.ak47Parts + " / " + ItemManager.ak47PartsNeeded + " )";
        }
    }

    ////////// Selected //////////

    public void SelectedAR15()
    {
        Debug.Log("Selected");
        backpack.BackpackAR15();
    }
    public void SelectedAK14()
    {
        Debug.Log("Selected");
        backpack.BackpackAK47();
    }



    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && IsOpen == true)
        {
            ForceEscape();
        }
    }

    void ForceEscape()
    {
        IsOpen = false;
    }

}

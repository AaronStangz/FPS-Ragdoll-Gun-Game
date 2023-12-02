using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class MapTable : MonoBehaviour
{
    Backpack backpack;
    Quests quests;

    [SerializeField] private PlayerCam cam;
    [SerializeField] private PlayerMovement move;
    public GameObject player;

    public float OpenRange;
    public bool IsOpen = false;

    public GameObject UI;

    [Header("Pages")]
    public GameObject QuestPage;
    public GameObject MapPage;
    public GameObject ShopPage;

    void Start()
    {
        backpack = player.GetComponent<Backpack>();
    }

    void Update()
    {
        Escape();


        if (IsOpen == false)
        {
            UI.SetActive(false);
        }

        if (IsOpen == true)
        {
            UI.SetActive(true);
            cam.enabled = false;
            move.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            backpack.OpenHandClose();
        }
    }
    ////////// Quests //////////
    public void Quests()
    {
        QuestPage.SetActive(true);
        ShopPage.SetActive(false);
        MapPage.SetActive(false);
    }


    ////////// Shop //////////
    public void Shop()
    {
        QuestPage.SetActive(false);
        ShopPage.SetActive(true);
        MapPage.SetActive(false);
    }

    ////////// Map //////////
    public void Map()
    {
        QuestPage.SetActive(false);
        ShopPage.SetActive(false);
        MapPage.SetActive(true);
    }

    public void OpenMenu()
    {
        IsOpen = true;
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
        Cursor.lockState = CursorLockMode.Locked;
    }
}

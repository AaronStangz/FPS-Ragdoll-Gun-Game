using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    ItemManager ItemManager;
    HoldGun HoldGun;

    public bool BackpackOpen = false;
    public bool OpenHand; 
    public bool OpenSlotRifle;

    public GameObject backpack;
    public GameObject Fpcamera;

    [SerializeField] private PlayerCam cam;
    [SerializeField] private PlayerMovement move;
    [SerializeField] private LayerMask InvItem;

    [Header("On Hand BluePrints")]
    public GameObject barricadeBluePrintPrefab;
    public GameObject spikeTrapBluePrintPrefab;

    [Header("On Hand Guns")]
    public GameObject uIAmmoText;
    public GameObject ar15OnHand;
    public GameObject ak47OnHand;

    [Header("Slot 1 Rifles")]
    public GameObject ar15Prefab;
    public GameObject ak47Prefab;
    public GameObject natoPrefab;


    void Start()
    {
        ItemManager = GetComponent<ItemManager>();
    }

    void Update()
    {
        Escape();
        ItemUpdate();

        if (Input.GetKeyDown(KeyCode.I) || (Input.GetKeyDown(KeyCode.Tab)))
        {
            BackpackOpen = true;
        }

        if (BackpackOpen == true)
        {
            OpenHand = true;
            uIAmmoText.SetActive(false);
            cam.enabled = false;
            move.enabled = false;
            Fpcamera.transform.rotation = Quaternion.Euler(35, Fpcamera.transform.rotation.eulerAngles.y, Fpcamera.transform.rotation.eulerAngles.z);
            backpack.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

        if (BackpackOpen == false)
        {
            backpack.SetActive(false);
            move.enabled = true;
            cam.enabled = true;
        }

        if (OpenHand == true)
        {
            ar15OnHand.SetActive(false);
            ak47OnHand.SetActive(false);
        }

        if (OpenSlotRifle == true)
        {
            ar15Prefab.SetActive(false);
            ak47Prefab.SetActive(false);
        }

            if (Camera.main == null) return;
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.DrawRay(Camera.main.transform.position, ray.direction * 10);

            if (Physics.Raycast(ray, out hit, 10, InvItem))
            {
                //Debug.Log("CanSelcet");
                HoldGun HoldGun = hit.collider.GetComponent<HoldGun>();
                if (HoldGun != null)
                {
                    if (Input.GetMouseButtonDown(1))
                    {
                        if (hit.collider.gameObject.tag == "AK-47")
                        {
                            Debug.Log("SelcetedAK-47");
                            HoldGun.Ak47();
                        }
                        else if (hit.collider.gameObject.tag == "AR-15")
                        {
                            Debug.Log("SelcetedAR-15");
                            HoldGun.AR15();
                        }
                        else if (hit.collider.gameObject.tag == "Nato")
                        {
                            Debug.Log("SelcetedNato");
                            HoldGun.Nato();
                        }
                        else if (hit.collider.gameObject.tag == "BarricadeBluePrint")
                        {
                            Debug.Log("SelcetedBarricadeBluePrint");
                            HoldGun.BarricadeBluePrint();
                        }
                        else if (hit.collider.gameObject.tag == "SpikeTrapBluePrint")
                        {
                            Debug.Log("SelcetedSpikeTrapBluePrint");
                            HoldGun.SpikeTrapBluePrint();
                        }
                        ForceEscape();
                    }
                }
            }
        }
    }

    public void ItemUpdate()
    {
        if (BackpackOpen == true)
        {
            if (ItemManager.barricadeBluePrint >= 1)
            {
                barricadeBluePrintPrefab.SetActive(true);
            }
            if (ItemManager.spikeTrapBluePrint >= 1)
            {
                spikeTrapBluePrintPrefab.SetActive(true);
            }
        }
    }

    ////////// Rifles //////////
    public void BackpackAR15()
    {
        //OpenSlotRifle = true;
        OpenHand = true;
        ar15Prefab.SetActive(true);
    }
    public void BackpackAK47()
    {
        //OpenSlotRifle = true;
        OpenHand = true;
        ak47Prefab.SetActive(true);
    }


    ////////// HandGuns //////////



    ////////// MachineGuns //////////


    public void holdAR15()
    {
        OpenSlotRifle = false;
        Debug.Log("holdAR15");
        ar15OnHand.SetActive(true);
        ForceEscape();
        uIAmmoText.SetActive(true);
        OpenHand = false;
    }

    public void holdAK47()
    {
        OpenSlotRifle = false;
        Debug.Log("holdAK47");
        ak47OnHand.SetActive(true);
        ForceEscape();
        uIAmmoText.SetActive(true);
        OpenHand = false;
    }

    public void OpenHandClose()
    {
        OpenHand = true;
        uIAmmoText.SetActive(false);
    }
    public void OpenSlotRifleClose()
    {
        OpenSlotRifle = true;
    }

    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && BackpackOpen == true)
        {
            ForceEscape();
        }
    }

    void ForceEscape()
    {
        BackpackOpen = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    ItemManager ItemManager;
    HoldGun HoldGun;
    public bool InvOpen = false;
    public GameObject inventory;
    public GameObject Fpcamera;
    [SerializeField] private PlayerCam cam;
    [SerializeField] private PlayerMovement move;
    [SerializeField] private LayerMask InvItem;

    public bool OpenHand;

    [Header("On Hand Guns")]
    public GameObject ar15OnHand;

    [Header("Guns")]
    public GameObject ak15Prefab;
    public GameObject ak47Prefab;
    public GameObject natoPrefab;

    [Header("Items")]
    public GameObject barricadePrefab;
    public GameObject spikeTrapPrefab;

    void Start()
    {
        ItemManager = GetComponent<ItemManager>();
    }

    void Update()
    {
        Escape();
        ItemCheck();

        if (Input.GetKeyDown(KeyCode.I) || (Input.GetKeyDown(KeyCode.Tab)))
        {
            InvOpen = true;
        }

        if (InvOpen == true)
        {
            cam.enabled = false;
            move.enabled = false;
            OpenHand = false;
            Fpcamera.transform.rotation = Quaternion.Euler(25, Fpcamera.transform.rotation.eulerAngles.y, Fpcamera.transform.rotation.eulerAngles.z);
            inventory.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

        if (InvOpen == false)
        {
            inventory.SetActive(false);
            move.enabled = true;
            cam.enabled = true;
            //Cursor.lockState = CursorLockMode.locked;
        }

        if (OpenHand == true)
        {
            ar15OnHand.SetActive(false);
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
                        else if(hit.collider.gameObject.tag == "AR-15")
                        {
                            Debug.Log("SelcetedAR-15");
                            HoldGun.AR15();
                        }
                        else if(hit.collider.gameObject.tag == "Nato")
                        {
                            Debug.Log("SelcetedNato");
                            HoldGun.Nato();
                        }
                        else if(hit.collider.gameObject.tag == "BarricadeBluePrint")
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

    void ItemCheck()
    {
        if (InvOpen == true)
        {
            //////////////////////////[ Guns ]//////////////////////////
            if (ItemManager.ar15 == 1)
            {
                ak15Prefab.SetActive(true);
            }
            else ak15Prefab.SetActive(false);
            if (ItemManager.ak47 == 1)
            {
                ak47Prefab.SetActive(true);
            }
            else ak47Prefab.SetActive(false);
            if (ItemManager.nato == 1)
            {
                natoPrefab.SetActive(true);
            }
            else natoPrefab.SetActive(false);

            //////////////////////////[ Items ]//////////////////////////
            if (ItemManager.barricadeBluePrint == 1)
            {
                barricadePrefab.SetActive(true);
            }
            else barricadePrefab.SetActive(false);
            if (ItemManager.spikeTrapBluePrint == 1)
            {
                spikeTrapPrefab.SetActive(true);
            }
            else spikeTrapPrefab.SetActive(false);

        }
        else return;
    }

    public void holdAR15()
    {
        Debug.Log("holdAR15");
        OpenHand = false;
        ar15OnHand.SetActive(true);
        ForceEscape();
        OpenHand = false;
    }


    void Escape()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && InvOpen == true)
        {
            ForceEscape();
            OpenHand = false;
        }
    }

    void ForceEscape()
    {
        InvOpen = false;
    }
}

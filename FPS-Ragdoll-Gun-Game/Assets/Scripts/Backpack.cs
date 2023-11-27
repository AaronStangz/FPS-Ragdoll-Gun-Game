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

    public GameObject backpack;
    public GameObject Fpcamera;

    [SerializeField] private PlayerCam cam;
    [SerializeField] private PlayerMovement move;
    [SerializeField] private LayerMask InvItem;

    [Header("On Hand Guns")]
    public GameObject ar15OnHand;

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

        if (Input.GetKeyDown(KeyCode.I) || (Input.GetKeyDown(KeyCode.Tab)))
        {
            BackpackOpen = true;
        }

        if (BackpackOpen == true)
        {
            cam.enabled = false;
            move.enabled = false;
            OpenHand = false;
            Fpcamera.transform.rotation = Quaternion.Euler(25, Fpcamera.transform.rotation.eulerAngles.y, Fpcamera.transform.rotation.eulerAngles.z);
            backpack.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

        if (BackpackOpen == false)
        {
            backpack.SetActive(false);
            move.enabled = true;
            cam.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
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

    ////////// Rifles //////////
    public void BackpackAR15()
    {
        ar15Prefab.SetActive(true);
        ak47Prefab.SetActive(false);
        natoPrefab.SetActive(false);
    }
    public void BackpackAK47()
    {
        ar15Prefab.SetActive(false);
        ak47Prefab.SetActive(true);
        natoPrefab.SetActive(false);
    }


    ////////// HandGuns //////////



    ////////// MachineGuns //////////


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
        if (Input.GetKeyDown(KeyCode.Escape) && BackpackOpen == true)
        {
            ForceEscape();
            OpenHand = false;
        }
    }

    void ForceEscape()
    {
        BackpackOpen = false;
    }
}

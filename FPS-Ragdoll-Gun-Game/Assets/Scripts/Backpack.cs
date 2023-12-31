using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    ItemManager ItemManager;
    HoldGun HoldGun;

    public bool BackpackOpen = false; 
    public bool OpenHand = false;

    public GameObject backpack;
    public GameObject Fpcamera;

    [SerializeField] private PlayerCam cam;
    [SerializeField] private PlayerMovement move;
    [SerializeField] private LayerMask InvItem;

    public GameObject uIAmmoText;

    [Header("On Hand BluePrints")]
    public GameObject barricadeBluePrintPrefab;
    public GameObject spikeTrapBluePrintPrefab;

    [Header("Rifles")]
    public GameObject assaultriflePrefab;
    public GameObject eclipseEnforcerPrefab;
    public GameObject phantomwhisperPrefab;

    [Header("Handgun")]
    public GameObject pistolePrefab;
    public GameObject cobaltSentinelPrefab;
    public GameObject zenithDefenderPrefab;

    [Header("Shotsguns")]
    public GameObject doublebarrelPrefab;
    public GameObject emberGuardianPrefab;
    public GameObject phoenixWingPrefab;

    [Header("MachineGuns")]
    public GameObject submachinePrefab;
    public GameObject nebulaHavocPrefab;
    public GameObject emberWarbringerPrefab;


    void Start()
    {
        ItemManager = GetComponent<ItemManager>();
    }

    void Update()
    {
        Escape();
        //ItemUpdate();

        if (Input.GetKeyDown(KeyCode.I) || (Input.GetKeyDown(KeyCode.Tab)))
        {
            BackpackOpen = true;
        }

        if (OpenHand == true) 
        {
            assaultriflePrefab.SetActive(false);
            eclipseEnforcerPrefab.SetActive(false);
            phantomwhisperPrefab.SetActive(false);

            pistolePrefab.SetActive(false);
            cobaltSentinelPrefab.SetActive(false);
            zenithDefenderPrefab.SetActive(false);

            doublebarrelPrefab.SetActive(false);
            emberGuardianPrefab.SetActive(false);
            phoenixWingPrefab.SetActive(false);

            submachinePrefab.SetActive(false);
            nebulaHavocPrefab.SetActive(false);
            emberWarbringerPrefab.SetActive(false);
        }

        if (BackpackOpen == true)
        {
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

        if (Camera.main == null) return;
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.DrawRay(Camera.main.transform.position, ray.direction * 10);

            if (Physics.Raycast(ray, out hit, 50, InvItem))
            {
                HoldGun HoldGun = hit.collider.GetComponent<HoldGun>();
                if (HoldGun != null)
                {
                Debug.Log("CanSelcet");
                    if (Input.GetMouseButtonDown(1))
                    {
                        if (hit.collider.gameObject.tag == "assaultrifle")
                        {
                            Debug.Log("Selceted");
                            assaultrifleHold();
                        }
                        else if (hit.collider.gameObject.tag == "eclipseEnforcer")
                        {
                            Debug.Log("Selceted");
                            eclipseEnforcerHold();
                        }
                        else if (hit.collider.gameObject.tag == "phantomwhisper")
                        {
                            Debug.Log("Selceted");
                            phantomwhisperHold();
                        }
                        else if (hit.collider.gameObject.tag == "pistole")
                        {
                            Debug.Log("Selceted");
                            pistoleHold();
                        }
                        else if (hit.collider.gameObject.tag == "cobaltSentinel")
                        {
                            Debug.Log("Selceted");
                            cobaltSentinelHold();
                        }
                        else if (hit.collider.gameObject.tag == "zenithDefender")
                        {
                            Debug.Log("Selceted");
                            zenithDefenderHold();
                        }
                        else if (hit.collider.gameObject.tag == "doublebarrel")
                        {
                            Debug.Log("Selceted");
                            doublebarrelHold();
                        }
                        else if (hit.collider.gameObject.tag == "emberGuardian")
                        {
                            Debug.Log("Selceted");
                            emberGuardianHold();
                        }
                        else if (hit.collider.gameObject.tag == "phoenixWing")
                        {
                            Debug.Log("Selceted");
                            phoenixWingHold();
                        }
                        else if (hit.collider.gameObject.tag == "submachine")
                        {
                            Debug.Log("Selceted");
                            submachineHold();
                        }
                        else if (hit.collider.gameObject.tag == "nebulaHavoc")
                        {
                            Debug.Log("Selceted");
                            nebulaHavocHold();
                        }
                        else if (hit.collider.gameObject.tag == "emberWarbringer")
                        {
                            Debug.Log("Selceted");
                            emberWarbringerHold();
                        }
                       // else if (hit.collider.gameObject.tag == "BarricadeBluePrint")
                       // {
                       //     Debug.Log("SelcetedBarricadeBluePrint");
                      //      HoldGun.BarricadeBluePrint();
                       // }
                      //  else if (hit.collider.gameObject.tag == "SpikeTrapBluePrint")
                      //  {
                     //       Debug.Log("SelcetedSpikeTrapBluePrint");
                     //       HoldGun.SpikeTrapBluePrint();
                     //   }
                     //   ForceEscape();
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
    public void assaultrifleHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        assaultriflePrefab.SetActive(true);
    }
    public void eclipseEnforcerHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        eclipseEnforcerPrefab.SetActive(true);
    }
    public void phantomwhisperHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        phantomwhisperPrefab.SetActive(true);
    }

    ////////// HandGuns //////////

    public void pistoleHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        pistolePrefab.SetActive(true);
    }
    public void cobaltSentinelHold()
    {
        //OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        cobaltSentinelPrefab.SetActive(true);
    }
    public void zenithDefenderHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        zenithDefenderPrefab.SetActive(true);
    }

    ////////// Shotguns //////////

    public void doublebarrelHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        doublebarrelPrefab.SetActive(true);
    }
    public void emberGuardianHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        emberGuardianPrefab.SetActive(true);
    }
    public void phoenixWingHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        phoenixWingPrefab.SetActive(true);
    }

    ////////// MachineGuns //////////

    public void submachineHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        submachinePrefab.SetActive(true);
    }
    public void nebulaHavocHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        nebulaHavocPrefab.SetActive(true);
    }
    public void emberWarbringerHold()
    {
        OpenHand = true;
        Debug.Log("Holding");
        OpenHand = false;
        ForceEscape();
        uIAmmoText.SetActive(true);
        emberWarbringerPrefab.SetActive(true);
    }

    public void OpenHandClose()
    {
        OpenHand = true;
        uIAmmoText.SetActive(false);
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

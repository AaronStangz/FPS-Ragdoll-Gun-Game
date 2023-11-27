using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UIElements;

public class Raycast : MonoBehaviour
{
    [SerializeField] private LayerMask Interactable;
    [SerializeField] private LayerMask Collectable;

    private LootBox LookingAtBox;
    private Collect LookingAtItem;
    private WeaponSmith OpenMenu;
    void Update()
    {
        if (Camera.main == null) return;

        RaycastHit hit;

        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 1000);
        if (Physics.SphereCast(ray, 0.5f, out hit, 10, Interactable + Collectable))
        {   
            
            if (Interactable.value == (1 << hit.collider.gameObject.layer))
            {   
                LootBox box = hit.collider.GetComponent<LootBox>();
                if(box != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (Vector3.Distance(transform.position, box.transform.position) < box.OpenRange)
                        {
                            Debug.Log("Opened");
                            box.open();
                        }
                    }
                }

                WeaponSmith station = hit.collider.GetComponent<WeaponSmith>();
                if (station != null)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (Vector3.Distance(transform.position, station.transform.position) < station.OpenRange)
                        {
                            Debug.Log("Opened");
                            station.OpenMenu();
                        }
                    }
                }


            }
            if (Collectable.value == (1 << hit.collider.gameObject.layer))
            {
                Collect item = hit.collider.GetComponent<Collect>();
                if(item != null) 
                {   
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (hit.distance < item.pickUpRange)
                        {
                            Debug.Log("Collected");
                            item.CollectItem();
                        }
                    }
                }
            }     
        }

      
    }
}

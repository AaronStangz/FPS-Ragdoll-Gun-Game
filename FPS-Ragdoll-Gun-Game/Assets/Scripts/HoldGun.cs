using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldGun : MonoBehaviour
{
    public Backpack backpack;
    public GameObject Barricade;
    public GameObject SpikeTrap;

    public void Ak47()
    {
        Debug.Log("holdingAK47");
        backpack.holdAR15();
    }
    public void AR15()
    {
        backpack.holdAR15();
        Debug.Log("holding");
    }
    public void Nato()
    {
        Debug.Log("holding");
    }

    public void BarricadeBluePrint()
    {
        Instantiate(Barricade, transform.position, transform.rotation);
        Debug.Log("Placeing");
    }

    public void SpikeTrapBluePrint()
    {
        Instantiate(SpikeTrap, transform.position, transform.rotation);
        Debug.Log("Placeing");
    }
}

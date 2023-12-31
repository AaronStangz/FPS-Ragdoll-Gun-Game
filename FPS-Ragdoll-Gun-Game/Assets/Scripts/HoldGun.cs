using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldGun : MonoBehaviour
{
    public Backpack backpack;
    public GameObject Barricade;
    public GameObject SpikeTrap;
    public GameObject player;

    void Start()
    {
        backpack = player.GetComponent<Backpack>();
    }
   // public void BarricadeBluePrint()
   // {
       // Instantiate(Barricade, transform.position, transform.rotation);
       // Debug.Log("Placeing");
   // }

   // public void SpikeTrapBluePrint()
   // {
       // Instantiate(SpikeTrap, transform.position, transform.rotation);
     //   Debug.Log("Placeing");
   // }
}

using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Collect : MonoBehaviour
{
    public float pickUpRange;

    [Header("What To Give")]
    public int GiveBarricadeBluePrint; 
    public int GiveSpikeTrapBluePrint;

    [Header("Guns")]
    public int GiveAR15;
    public int GiveAk47;

    [Header("GunsParts")]
    public int GiveAR15Parts;
    public int GiveAK47Parts;

    GameObject player;
    ItemManager ItemManager;
    void Start()
    {
        player = GameObject.Find("Player");
        ItemManager = player.GetComponent<ItemManager>();
    }
    public void CollectItem()
    {
        if (ItemManager.barricadeBluePrint < 1)
        {
            ItemManager.barricadeBluePrint += GiveBarricadeBluePrint;
            Destroy(gameObject);
        }
        if (ItemManager.spikeTrapBluePrint < 1)
        {
            ItemManager.spikeTrapBluePrint += GiveSpikeTrapBluePrint;
            Destroy(gameObject);
        }

        if (ItemManager.ar15Parts < 1000)
        {
            ItemManager.ar15Parts += GiveAR15Parts;
            Destroy(gameObject);
        }
        if (ItemManager.ak47Parts < 1000)
        {
            ItemManager.ak47Parts += GiveAK47Parts;
            Destroy(gameObject);
        }
    }
}

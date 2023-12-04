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

    [Header("StoryItems")]
    public int GiveFiles;

    [Header("Guns")]
    public int GiveAR15;
    public int GiveAk47;

    [Header("GunsParts")]
    public int GiveAR15Parts;
    public int GiveAK47Parts;

    public GameObject mainManager;
    ItemManager ItemManager;
    void Start()
    {
        ItemManager = mainManager.GetComponent<ItemManager>();
    }
    public void CollectItem()
    {
        if (ItemManager.barricadeBluePrint < 1)
        {
            ItemManager.barricadeBluePrint += GiveBarricadeBluePrint;
            Destroy(gameObject);
        }
        if(ItemManager.spikeTrapBluePrint < 1)
        {
            ItemManager.spikeTrapBluePrint += GiveSpikeTrapBluePrint;
            Destroy(gameObject);
        }
        if (ItemManager.files < 100)
        {
            ItemManager.files += GiveFiles;
            Destroy(gameObject);
        }

        if (ItemManager.assaultrifleParts < 1000)
        {
            ItemManager.assaultrifleParts += GiveAR15Parts;
            Destroy(gameObject);
        }
        if (ItemManager.eclipseEnforcerParts < 1000)
        {
            ItemManager.eclipseEnforcerParts += GiveAK47Parts;
            Destroy(gameObject);
        }
    }
}

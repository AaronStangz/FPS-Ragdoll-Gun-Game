using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [Header("Mats")]
    public int trashBlockCount;

    [Header("Items")]
    public int barricadeBluePrint;
    public int spikeTrapBluePrint;

    [Header("Guns")]
    public int ar15;
    public int ak47;
    public int nato;

    [Header("ammo")]
    public int arAmmo;
    public int smgAmmo;
    public int shotgunAmmo;

    [Header("GunParts")]
    public int ar15Parts;
    public int ak47Parts;
    public int natoParts;

    [Header("GunPartsNeeded")]
    public int ar15PartsNeeded;
    public int ak47PartsNeeded;
    public int natoPartsNeeded;
}

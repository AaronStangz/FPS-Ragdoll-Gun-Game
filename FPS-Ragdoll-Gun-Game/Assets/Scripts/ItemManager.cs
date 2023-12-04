using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class ItemManager : MonoBehaviour
{
    [Header("Mats")]
    public int goldBar;

    [Header("Items")]
    public int barricadeBluePrint;
    public int spikeTrapBluePrint;

    [Header("StoryItems")]
    public int files;

    [Header("ammo")]
    public int arAmmo;
    public int smgAmmo;
    public int shotgunAmmo;

    [Header("GunParts")]
    public int assaultrifleParts;
    public int eclipseEnforcerParts;
    public int phantomwhisperParts;
    [Header("")]
    public int pistoleParts;
    public int cobaltSentinelParts;
    public int zenithDefenderParts;
    [Header("")]
    public int doublebarrelParts;
    public int emberGuardianParts;
    public int phoenixWingParts;
    [Header("")]
    public int submachineParts;
    public int nebulaHavocParts;
    public int emberWarbringerParts;

    [Header("GunPartsNeeded")]
    public int assaultriflePartsNeeded;
    public int eclipseEnforcerPartsNeeded;
    public int phantomwhisperPartsNeeded;
    [Header("")]
    public int pistolePartsNeeded;
    public int cobaltSentinelPartsNeeded;
    public int zenithDefenderPartsNeeded;
    [Header("")]
    public int doublebarrelPartsNeeded;
    public int emberGuardianPartsNeeded;
    public int phoenixWingPartsNeeded;
    [Header("")]
    public int submachinePartsNeeded;
    public int nebulaHavocPartsNeeded;
    public int emberWarbringerPartsNeeded;

}

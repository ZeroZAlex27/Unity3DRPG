using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEffectsManager : MonoBehaviour
{
    PlayerStats playerStats;
    WeaponSlotManager weaponSlotManager;
    public GameObject instantiatedFXModel;
    public int amountToBeHealed;

    private void Awake()
    {
        playerStats = GetComponentInParent<PlayerStats>();
        weaponSlotManager = GetComponent<WeaponSlotManager>();
    }

    public void HealPlayerFromEffect()
    {
        playerStats.HealPlayer(amountToBeHealed);
        Destroy(instantiatedFXModel.gameObject);
        weaponSlotManager.LoadBothWeaponsOnSlots();
    }
}

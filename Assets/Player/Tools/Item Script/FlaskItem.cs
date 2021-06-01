using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Consumables/Flask")]
public class FlaskItem : ConsumableItem
{
    [Header("Flask Type")]
    public bool healthFlask;

    [Header("Recovery Amount")]
    public int healthRecoverAmount;

    public override void AttemptToConsumeItem(AnimatorManager animatorManager, WeaponSlotManager weaponSlotManager, PlayerEffectsManager playerEffectsManager)
    {
        base.AttemptToConsumeItem(animatorManager, weaponSlotManager, playerEffectsManager);
        GameObject flask = Instantiate(itemModel, weaponSlotManager.rightHandSlot.transform);
        playerEffectsManager.amountToBeHealed = healthRecoverAmount;
        playerEffectsManager.instantiatedFXModel = flask;
        weaponSlotManager.rightHandSlot.UnloadWeapon();
    }
}

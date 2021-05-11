using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    AnimatorManager animatorManager;
    PlayerLocomotion playerLocomotion;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
    }

    public void HandleLightAttack(WeaponItem weapon)
    {
        if (playerLocomotion.isDead)
            return;
        animatorManager.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
    }

    public void HandleHeavyAttack(WeaponItem weapon)
    {
        if (playerLocomotion.isDead)
            return;
        animatorManager.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
    }
}

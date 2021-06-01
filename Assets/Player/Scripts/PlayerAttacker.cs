using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using UnityEngine;

public class PlayerAttacker : MonoBehaviour
{
    AnimatorManager animatorManager;
    PlayerLocomotion playerLocomotion;
    InputManager inputManager;
    public string lastAttack;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        inputManager = GetComponent<InputManager>();
    }

    public void HandleWeaponCombo(WeaponItem weapon)
    {
        if (playerLocomotion.isDead || inputManager.interactingFlag)
            return;
        if (inputManager.comboInput)
        {
            animatorManager.animator.SetBool("canDoCombo", false);

            string attackType1 = lastAttack.Substring(0, 2);
            string attackType2;
            if (lastAttack.Contains("_Light_Attack_"))
            {
                attackType2 = "_Light_Attack_";
            }
            else
            {
                attackType2 = "_Heavy_Attack_";
            }
            string indexOfAttack = lastAttack.Substring(lastAttack.Length - 1);
            string nextAttackVar = attackType1 + attackType2 + (int.Parse(indexOfAttack) + 1);
            Type typeWeaponItem = typeof(WeaponItem);
            if (typeWeaponItem.GetTypeInfo().GetDeclaredField(nextAttackVar) != null)
            {
                string nextAttack = lastAttack.Substring(0, lastAttack.Length - 1) + (int.Parse(indexOfAttack) + 1);
                animatorManager.PlayTargetAnimation(nextAttack, true);
                lastAttack = nextAttack;
            }
        }
    }

    public void HandleLightAttack(WeaponItem weapon)
    {
        if (playerLocomotion.isDead || inputManager.interactingFlag)
            return;
        if (inputManager.twoHandFlag)
        {
            animatorManager.PlayTargetAnimation(weapon.TH_Light_Attack_1, true);
            lastAttack = weapon.TH_Light_Attack_1;
        }
        else
        {
            animatorManager.PlayTargetAnimation(weapon.OH_Light_Attack_1, true);
            lastAttack = weapon.OH_Light_Attack_1;
        }

    }

    public void HandleHeavyAttack(WeaponItem weapon)
    {
        if (playerLocomotion.isDead || inputManager.interactingFlag)
            return;
        if (inputManager.twoHandFlag)
        {
            animatorManager.PlayTargetAnimation(weapon.TH_Heavy_Attack_1, true);
            lastAttack = weapon.TH_Heavy_Attack_1;
        }
        else
        {
            animatorManager.PlayTargetAnimation(weapon.OH_Heavy_Attack_1, true);
            lastAttack = weapon.OH_Heavy_Attack_1;
        }
    }
}

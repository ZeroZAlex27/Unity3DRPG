using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapon Item")]
public class WeaponItem : Item
{
    public GameObject modelPrefab;
    public bool isUnarmed;

    [Header("Idle Animations")]
    public string Right_Hand_Idle;
    public string Left_Hand_Idle;
    public string th_idle;

    [Header("One Handed Attack Animations")]
    public string OH_Light_Attack_1;
    public string OH_Light_Attack_2;
    public string OH_Light_Attack_3;
    public string OH_Light_Attack_4;
    public string OH_Heavy_Attack_1;
    public string OH_Heavy_Attack_2;
    public string OH_Heavy_Attack_3;
    public string OH_Heavy_Attack_4;

    [Header("Two Handed Attack Animations")]
    public string TH_Light_Attack_1;
    public string TH_Light_Attack_2;
    public string TH_Light_Attack_3;
    public string TH_Heavy_Attack_1;
    public string TH_Heavy_Attack_2;
    public string TH_Heavy_Attack_3;
}

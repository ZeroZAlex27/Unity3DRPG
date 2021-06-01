using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public EquipmentWindowUI equipmentWindowUI;
    public InputManager inputManager;

    [Header("UI Windows")]
    public GameObject hudWindow;
    public GameObject inventoryScreenWindow;
    public GameObject equipmentScreenWindow;

    [Header("Equipment Window Slot Selected")]
    public bool rightHandSlot01Selected;
    public bool rightHandSlot02Selected;
    public bool leftHandSlot01Selected;
    public bool leftHandSlot02Selected;

    [Header("Weapon Inventory")]
    public GameObject weaponInventorySlotPrefab;
    public Transform weaponInventorySlotsParent;
    WeaponInventorySlot[] weaponInventorySlots;

    private void Awake()
    {
        inputManager = FindObjectOfType<InputManager>();
    }

    private void Start()
    {
        weaponInventorySlots = weaponInventorySlotsParent.GetComponentsInChildren<WeaponInventorySlot>();
        equipmentWindowUI.LoadWeaponsOnEquipmentScreen(playerInventory);
    }

    private void LateUpdate()
    {
        inputManager.inventroyFlag = inventoryScreenWindow.activeInHierarchy;
        inputManager.equipmentFlag = equipmentScreenWindow.activeInHierarchy;   
    }

    public void UpdateUI()
    {
        #region Weapon Inventory Slots
        for(int i = 0; i < weaponInventorySlots.Length; i++)
        {
            if(i < playerInventory.weaponsInventory.Count)
            {
                if(weaponInventorySlots.Length < playerInventory.weaponsInventory.Count)
                {
                    Instantiate(weaponInventorySlotPrefab, weaponInventorySlotsParent);
                    weaponInventorySlots = weaponInventorySlotsParent.GetComponentsInChildren<WeaponInventorySlot>();
                }
                weaponInventorySlots[i].AddItem(playerInventory.weaponsInventory[i]);
            }
            else
            {
                weaponInventorySlots[i].ClearInventorySlot();
            }
        }
        #endregion
    }

    public void OpenInventoryWindow()
    {
        inventoryScreenWindow.SetActive(true);
    }

    public void CloseInventoryWindow()
    {
        inventoryScreenWindow.SetActive(false);
    }

    public void OpenCharacterEquipmentWindow()
    {
        equipmentScreenWindow.SetActive(true);
    }

    public void CloseCharacterEquipmentWindow()
    {
        equipmentScreenWindow.SetActive(false);
    }

    public void ResetAllSelectedSlots()
    {
        rightHandSlot01Selected = false;
        rightHandSlot02Selected = false;
        leftHandSlot01Selected = false;
        leftHandSlot02Selected = false;
    }
}

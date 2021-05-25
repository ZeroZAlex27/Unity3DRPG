using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;
    PlayerLocomotion playerLocomotion;
    AnimatorManager animatorManager;
    PlayerManager playerManager;
    PlayerAttacker playerAttacker;
    PlayerInventory playerInventory;
    WeaponSlotManager weaponSlotManager;
    UIManager uiManager;

    public Vector2 movementInput;
    public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;

    public bool wqs_up;
    public bool wqs_down;
    public bool wqs_left;
    public bool wqs_right;

    public bool interactableInput;
    public bool inventoryInput;

    public bool inventroyFlag;
    public bool twoHandFlag;

    public float moveAmount;
    public float verticalInput;
    public float horizontalInput;

    public bool runInput;
    public bool jumpInput;
    public bool rollInput;
    public bool comboInput;
    public bool twoHandInput;

    public bool lightAttackInput;
    public bool heavyAttackInput;
    public bool doubleAttackInput;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerManager = GetComponent<PlayerManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        playerAttacker = GetComponent<PlayerAttacker>();
        playerInventory = GetComponent<PlayerInventory>();
        weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.Player.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
            playerControls.Player.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

            playerControls.Player.Run.performed += i => runInput = true;
            playerControls.Player.Run.canceled += i => runInput = false;
            playerControls.Player.Jump.performed += i => jumpInput = true;
            playerControls.Player.Roll.performed += i => rollInput = true;

            playerControls.Player.LightAttack.performed += i => lightAttackInput = true;
            playerControls.Player.HeavyAttack.performed += i => heavyAttackInput = true;
            playerControls.Player.DoubleAttack.performed += i => doubleAttackInput = true;

            playerControls.Player.WeaponsQuickSlotsUp.performed += i => wqs_up = true;
            playerControls.Player.WeaponsQuickSlotsDown.performed += i => wqs_down = true;
            playerControls.Player.WeaponsQuickSlotsLeft.performed += i => wqs_left = true;
            playerControls.Player.WeaponsQuickSlotsRight.performed += i => wqs_right = true;

            playerControls.Player.Interact.performed += i => interactableInput = true;
            playerControls.Player.Inventory.performed += i => inventoryInput = true;
            playerControls.Player.TwoHanding.performed += i => twoHandInput = true;
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
        HandleSprintingInput();
        HandleJumpingInput();
        HandleRollingInput();
        HandleAttackInput();
        HandleQuickSlotInput();
        HandleInteractingInput();
        HandleInventoryInput();
        HandleTwoHandInput();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;

        cameraInputY = cameraInput.y;
        cameraInputX = cameraInput.x;

        animatorManager.UpdateAnimatorValues(horizontalInput, verticalInput, playerLocomotion.isRunning);
    }

    private void HandleSprintingInput()
    {
        if (runInput && verticalInput > 0)
        {
            playerLocomotion.isRunning = true;
        }
        else
        {
            playerLocomotion.isRunning = false;
        }
    }

    private void HandleJumpingInput()
    {
        if(jumpInput)
        {
            jumpInput = false;
            playerLocomotion.HandleJumping();
        }
    }

    private void HandleRollingInput()
    {
        if(rollInput)
        {
            rollInput = false;
            playerLocomotion.HandleRolling();
        }
    }

    private void HandleAttackInput()
    {
        if (!playerManager.isInteracting)
        {
            playerAttacker.lastAttack = null;
        }

        if(doubleAttackInput)
        {
            doubleAttackInput = false;
            if ((playerManager.isInteracting && playerAttacker.lastAttack == playerInventory.rightWeapon.OH_Double_Light_Attack_1) 
                || playerLocomotion.canDoCombo)
                return;
            playerAttacker.HandleDoubleAttack(playerInventory.rightWeapon);
        }

        if (lightAttackInput)
        {
            lightAttackInput = false;
            if (playerLocomotion.canDoCombo)
            {
                if (playerAttacker.lastAttack.Contains("_Light_Attack_"))
                {
                    comboInput = true;
                    playerAttacker.HandleWeaponCombo(playerInventory.rightWeapon);
                    comboInput = false;
                }
                else
                {
                    if (playerManager.isInteracting && playerAttacker.lastAttack.Contains("_Light_Attack_1"))
                        return;
                    playerAttacker.HandleLightAttack(playerInventory.rightWeapon);
                }
            }
            else
            {
                if (playerManager.isInteracting && playerAttacker.lastAttack.Contains("_Light_Attack_1"))
                    return;
                playerAttacker.HandleLightAttack(playerInventory.rightWeapon);
            }
        }

        if (heavyAttackInput)
        {
            heavyAttackInput = false;
            if (playerLocomotion.canDoCombo)
            {
                if (playerAttacker.lastAttack.Contains("_Heavy_Attack_"))
                {
                    comboInput = true;
                    playerAttacker.HandleWeaponCombo(playerInventory.leftWeapon);
                    comboInput = false;
                }
                else
                {
                    if (playerManager.isInteracting && playerAttacker.lastAttack.Contains("_Heavy_Attack_1"))
                        return;
                    playerAttacker.HandleHeavyAttack(playerInventory.leftWeapon);
                }
            }
            else
            {
                if (playerManager.isInteracting && playerAttacker.lastAttack.Contains("_Heavy_Attack_1"))
                    return;
                playerAttacker.HandleHeavyAttack(playerInventory.leftWeapon);
            }
        }
    }

    private void HandleQuickSlotInput()
    {
        if (wqs_right)
        {
            wqs_right = false;
            playerInventory.ChangeRightWeapon();
        }
        else if (wqs_left)
        {
            wqs_left = false;
            playerInventory.ChangeLeftWeapon();
        }
    }

    private void HandleInteractingInput()
    {
        
    }

    private void HandleInventoryInput()
    {
        if (inventoryInput)
        {
            inventoryInput = false;
            inventroyFlag = !inventroyFlag;

            if (inventroyFlag)
            {
                uiManager.OpenSelectWindow();
                uiManager.UpdateUI();
                uiManager.hudWindow.SetActive(false);
            }
            else
            {
                uiManager.CloseSelectWindow();
                uiManager.CloseAllInventoryWindows();
                uiManager.hudWindow.SetActive(true);
            }
        }
    }

    private void HandleTwoHandInput()
    {
        if (twoHandInput)
        {
            twoHandInput = false;
            twoHandFlag = !twoHandFlag;

            if (twoHandFlag)
            {
                weaponSlotManager.LoadWeaponOnSlot(playerInventory.rightWeapon, false);
            }
            else
            {
                weaponSlotManager.LoadWeaponOnSlot(playerInventory.rightWeapon, false);
                weaponSlotManager.LoadWeaponOnSlot(playerInventory.leftWeapon, true);
            }
        }
    }
}

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

    public Vector2 movementInput;
    public Vector2 cameraInput;

    public float cameraInputX;
    public float cameraInputY;

    public float moveAmount;
    public float verticalInput;
    public float horizontalInput;

    public bool runInput;
    public bool jumpInput;
    public bool rollInput;
    public bool comboInput;

    public bool lightAttackInput;
    public bool heavyAttackInput;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        playerManager = GetComponent<PlayerManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        playerAttacker = GetComponent<PlayerAttacker>();
        playerInventory = GetComponent<PlayerInventory>();
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
        if (lightAttackInput)
        {
            lightAttackInput = false;
            if (playerLocomotion.canDoCombo && playerAttacker.lastAttack == playerInventory.rightWeapon.OH_Light_Attack_1)
            {
                comboInput = true;
                playerAttacker.HandleWeaponCombo(playerInventory.rightWeapon);
                comboInput = false;
            }
            else
            {
                if (playerManager.isInteracting && playerAttacker.lastAttack == playerInventory.rightWeapon.OH_Light_Attack_1)
                    return;
                playerAttacker.HandleLightAttack(playerInventory.rightWeapon);
            }
        }

        if (heavyAttackInput)
        {
            heavyAttackInput = false;
            if (playerLocomotion.canDoCombo && playerAttacker.lastAttack == playerInventory.leftWeapon.OH_Heavy_Attack_1)
            {
                comboInput = true;
                playerAttacker.HandleWeaponCombo(playerInventory.leftWeapon);
                comboInput = false;
            }
            else
            {
                if (playerManager.isInteracting && playerAttacker.lastAttack == playerInventory.leftWeapon.OH_Heavy_Attack_1)
                    return;
                playerAttacker.HandleHeavyAttack(playerInventory.leftWeapon);
            }
        }
    }
}

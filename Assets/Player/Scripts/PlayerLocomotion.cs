using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    PlayerManager playerManager;
    AnimatorManager animatorManager;
    InputManager inputManager;

    Vector3 moveDirection;
    Transform cameraObject;
    public Rigidbody playerRigidBody;

    [Header("Falling")]
    public float inAirTimer;
    public float leapingVelocity;
    public float fallingVelocity;
    public float rayCastHeightOffSet = 0.5f;
    public LayerMask groundLayer;

    [Header("Movement Flags")]
    public bool isDead;
    public bool isRunning;
    public bool isGrounded;
    public bool isJumping;
    public bool isRolling;
    public bool startRolling;
    public bool canDoCombo;

    [Header("Movement Speeds")]
    public float walkingBSpeed = 1.5f;
    public float walkingTSpeed = 3;
    public float walkingSpeed = 3;
    public float runningSpeed = 7;
    public float rotationSpeed = 15;
    public float rollSpeed = 5;

    [Header("Jump Speeds")]
    public float jumpHeight = 1;
    public float gravityIntensity = -9.81f;
    

    private void Awake()
    {
        playerManager = GetComponent<PlayerManager>();
        animatorManager = GetComponent<AnimatorManager>();
        inputManager = GetComponent<InputManager>();
        playerRigidBody = GetComponent<Rigidbody>();
        cameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        HandleFallingAndLanding();

        if (playerManager.isInteracting)
            return;
        HandleMovement();
        HandleRotation();
        HandleImpulse();
    }

    private void HandleMovement()
    {
        if (isJumping || isRolling || isDead)
            return;

        moveDirection = cameraObject.forward * inputManager.verticalInput;
        moveDirection += cameraObject.right * inputManager.horizontalInput;
        moveDirection.Normalize();
        moveDirection.y = 0;

        if(isRunning && isGrounded)
        {
            moveDirection *= runningSpeed;
        }
        else if(inputManager.verticalInput <= -1 && isGrounded)
        {
            moveDirection *= walkingBSpeed;
        }
        else if(inputManager.horizontalInput != 0 && isGrounded)
        {
            moveDirection *= walkingTSpeed;
        }
        else
        {
            moveDirection *= walkingSpeed;
        }

        Vector3 movementVelocity = moveDirection;
        playerRigidBody.velocity = movementVelocity;
    }

    private void HandleRotation()
    {
        if (isJumping || isRolling)
            return;

        Vector3 targetDirection = Vector3.zero;

        targetDirection = cameraObject.forward * Mathf.Abs(inputManager.verticalInput);
        if(inputManager.horizontalInput == 1 && inputManager.verticalInput == 0)
        {
            targetDirection += cameraObject.forward * inputManager.horizontalInput;
        }
        else if(inputManager.horizontalInput == -1 && inputManager.verticalInput == 0)
        {
            targetDirection -= cameraObject.forward * inputManager.horizontalInput;
        }
        else if(inputManager.verticalInput == 1 && inputManager.horizontalInput != 0)
        {
            targetDirection += cameraObject.right * inputManager.horizontalInput;
        }
        else if(inputManager.verticalInput == -1 && inputManager.horizontalInput != 0)
        {
            targetDirection -= cameraObject.right * inputManager.horizontalInput;
        }
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero)
            targetDirection = transform.forward;

        Quaternion targerRotation = Quaternion.LookRotation(targetDirection);

        transform.rotation = targerRotation;
    }

    private void HandleImpulse()
    {
        if (!isRolling)
        {
            startRolling = false;
            return;
        }

        if (!startRolling)
        {
            startRolling = true;
            moveDirection = cameraObject.forward * inputManager.verticalInput;
            moveDirection += cameraObject.right * inputManager.horizontalInput;
            moveDirection.Normalize();
            moveDirection.y = 0;
            moveDirection *= rollSpeed;
        }

        Vector3 movementVelocity = moveDirection;
        playerRigidBody.velocity = movementVelocity;
    }

    private void HandleFallingAndLanding()
    {
        RaycastHit hit;
        Vector3 rayCastOrigin = transform.position;
        rayCastOrigin.y += rayCastHeightOffSet;

        if(!isGrounded && !isJumping && !isRolling)
        {
            if(!playerManager.isInteracting)
            {
                animatorManager.PlayTargetAnimation("Falling", true);
            }

            inAirTimer += Time.deltaTime;
            playerRigidBody.AddForce(transform.forward * leapingVelocity);
            playerRigidBody.AddForce(-Vector3.up * fallingVelocity * inAirTimer);
        }

        if(Physics.SphereCast(rayCastOrigin, 0.2f, -Vector3.up, out hit, groundLayer))
        {
            if(!isGrounded && !playerManager.isInteracting)
            {
                animatorManager.PlayTargetAnimation("Landing", true);
            }

            inAirTimer = 0;
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    public void HandleJumping()
    {
        if (isDead)
            return;
        if(isGrounded && !isRolling)
        {
            animatorManager.animator.SetBool("isJumping", true);
            animatorManager.PlayTargetAnimation("Jumping", false);

            float jumpingVelocity = Mathf.Sqrt(-2 * gravityIntensity * jumpHeight);
            Vector3 playerVelocity = moveDirection;
            playerVelocity.y = jumpingVelocity;
            playerRigidBody.velocity = playerVelocity;
        }
    }

    public void HandleRolling()
    {
        if (isDead)
            return;
        if(isGrounded && !isRolling)
        {
                if(inputManager.horizontalInput != 0 || inputManager.verticalInput != 0)
                {
                    animatorManager.animator.SetBool("isRolling", true);
                    animatorManager.PlayTargetAnimation("Rolling", false);

                    Quaternion rollRotation = Quaternion.LookRotation(moveDirection);
                    transform.rotation = rollRotation;
                }
        }
    }
}
    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public InputManager inputManager;
    public PlayerLocomotion playerLocomotion;
    int horizontal;
    int vertical;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        inputManager = GetComponent<InputManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }

    public void PlayTargetAnimation(string targetAnimation, bool isInteracting)
    {
        animator.applyRootMotion = true;
        animator.SetBool("isInteracting", isInteracting);
        animator.CrossFade(targetAnimation, 0.2f);
    }

    public void UpdateAnimatorValues(float horizontalMovement, float verticalMovement, bool isRunning)
    {
        if(isRunning)
        {
            verticalMovement = 2;
        }

        animator.SetFloat(horizontal, horizontalMovement, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, verticalMovement, 0.1f, Time.deltaTime);
    }

    private void OnAnimatorMove()
    {
        if (playerLocomotion.isRolling == false)
            return;

        playerLocomotion.playerRigidBody.drag = 0;
        Vector3 deltaPosition = animator.deltaPosition;
        deltaPosition.y = 0;
        Vector3 velocity = deltaPosition / Time.deltaTime;
        playerLocomotion.playerRigidBody.velocity = velocity;
    }
}

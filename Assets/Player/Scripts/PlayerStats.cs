using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int healthLevel = 10;
    public int maxHealth;
    public int currentHealth;

    public HealthBar healthBar;

    AnimatorManager animatorManager;
    PlayerLocomotion playerLocomotion;
    CapsuleCollider collider;
    Rigidbody rigidbody;

    private void Awake()
    {
        animatorManager = GetComponentInChildren<AnimatorManager>();
        playerLocomotion = GetComponent<PlayerLocomotion>();
        collider = GetComponent<CapsuleCollider>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        playerLocomotion.isDead = false;
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (playerLocomotion.isDead)
            return;

        currentHealth -= damage;

        healthBar.SetCurrentHealth(currentHealth);

        animatorManager.PlayTargetAnimation("Take Damage", true);

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            playerLocomotion.isDead = true;
            animatorManager.PlayTargetAnimation("Death", true);
            collider.direction = 2;
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionY;
            collider.radius = 0.1f;
        }
    }
}

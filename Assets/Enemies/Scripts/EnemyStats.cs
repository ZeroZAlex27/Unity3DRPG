using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int healthLevel = 10;
    public int maxHealth;
    public int currentHealth;

    bool isDead;

    Animator animator;
    CapsuleCollider collider;
    Rigidbody rigidbody;
    

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        collider = GetComponent<CapsuleCollider>();
        rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        isDead = false;
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
    }

    public int SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (isDead)
            return;

        currentHealth -= damage;

        animator.Play("Take Damage");

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            animator.Play("Death");
            collider.direction = 2;
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
            rigidbody.constraints &= ~RigidbodyConstraints.FreezePositionY;
            collider.radius = 0.1f;
        }
    }
}

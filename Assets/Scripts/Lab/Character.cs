using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    [SerializeField] Hpbar hpbar;

    public Animator anim;
    public Rigidbody2D rb;
    public bool IsDead()
    {
        return Health <= 0;
    }
    public void TakeDamage(int damage)
    {
        Health -= damage;
        hpbar.UpdateHealthBar(Health);
        IsDead();
    }
    public void Init(int newHealth)
    {
        Health = newHealth;
        hpbar.SetMaxHP(newHealth);
        hpbar.UpdateHealthBar(Health);
    }
}

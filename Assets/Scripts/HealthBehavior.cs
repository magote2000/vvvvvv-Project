using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class HealthBehavior : MonoBehaviour
{
    public int maxHealth = 1;
    public int health = 1;

    public UnityEvent isDying;
    public UnityEvent isDead;

    public void Init()
    {
        health = maxHealth;
    }

    public void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            health = 0;
            isDying.Invoke();
        }
    }

    public void Heal(int heal)
    {
        health += heal;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public void Dead()
    {
        isDead.Invoke();
    }
}

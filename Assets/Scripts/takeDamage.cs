using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    public int maxHealth;
    public int health;

    public void takeDamagef(int damage)
    {
        health = health - damage;
    }
}

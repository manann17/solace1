using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHealth = 100;
    private float currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void takeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
    }


    void Update()
    {
        if (currentHealth <= 0)
        {
            //die
        }
    }
}

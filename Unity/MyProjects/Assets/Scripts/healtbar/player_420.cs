using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_420 : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public Healthbar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keycode.space))
        {
            TakeDamage(2);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}

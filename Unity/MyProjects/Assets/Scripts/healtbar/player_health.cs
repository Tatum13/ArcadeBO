using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_health : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public GameObject test;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        test = GameObject.Find("test");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            TakeDamage(20);
        }

        if(currentHealth == 0) //death
        {
            SceneManager.LoadScene("hoofdmenu");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //dit was een test om damge te krijgen
        if (collision.gameObject == test)
        {
            TakeDamage(10);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("Egg"))
        {
            IncreaseHealth(Random.Range(1, 20));
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void IncreaseHealth(int increase)
    {
        currentHealth += increase;
        healthBar.SetHealth(currentHealth);

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}

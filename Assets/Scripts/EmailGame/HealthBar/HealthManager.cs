using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{
    //The max health
    public int maxHealth = 100;

    //The current health
    public int currentHealth;

    //The healthbar
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (currentHealth == 0)
        {
            //When your health reaches 0 you go to the lose screen
            Debug.Log("You are dead");
            SceneManager.LoadScene("EmailLoseScreen");    
        }
    }

    //Function that changes the health when you take damage
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}

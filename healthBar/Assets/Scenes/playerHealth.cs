using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour {
    public float currentHealth { get; set; }
    public float maxHealth { get; set; }

    public Slider healthBar;

    public float timer = 5;

	void Start ()
    {
        //can be any value of course
        maxHealth = 20f;

        //Rest the health bar to full on game load
        currentHealth = maxHealth;

        //Get the value of the slider 
        //set it to calculate health
        healthBar.value = CalculateHealth();
        Debug.Log("Start");

	}
	

	void Update ()
    {

        timer -= 0.5f;

		if (timer <= 0)
        {
            DealDamage(0.1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            RestoreHealth(1);
        }
	}


    void DealDamage(float damageValue)
    {

        Debug.Log("Dealing Damage");
        //Deal damage to the health bar
        currentHealth -= damageValue;
        healthBar.value = CalculateHealth();
        //If the character is out of health, they die
        if (currentHealth <= 0)
            Die();
    }

    void RestoreHealth(float healthGained)
    {
        //Deal damage to the health bar
        currentHealth += healthGained;
        healthBar.value = CalculateHealth();
        //If the character is out of health, they die
        if (currentHealth >= maxHealth)
        {
            currentHealth -= 1;
            Debug.Log("Health has been restored to full");
        }
           
    }


    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }

    void Die()
    {
        currentHealth = 0;
        Debug.Log("Transition to game over scene, then reload");
    }
}

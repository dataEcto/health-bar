using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class playerHealth : MonoBehaviour {
    /// <summary>
    /// Set Up Variables
    /// </summary>
    public float currentHealth { get; set; }
    public float maxHealth { get; set; }
    public Text healthBarText;
    public Text timerText;
    public Animator animator;
    private string levelToLoad;

    /// <summary>
    /// In Game used Variables
    /// </summary>
    public Slider healthBar;
    public float timer = 10;
    public float damageTimer = 30;
    public bool shouldHeal = false;
     
	void Start ()
    {
        //can be any value of course
        maxHealth = 100f;

        //Rest the health bar to full on game load
        currentHealth = maxHealth;

        //Get the value of the slider 
        //set it to calculate health
        healthBar.value = CalculateHealth();

        healthBarText.text = "Health: " + currentHealth;
        timerText.text = "Start mashing in..." + timer;

    

	}
	

	void Update ()
    {

        timer -= 1 * Time.deltaTime;
        healthBarText.text = "Health: " + Mathf.Round(currentHealth);

 
        if (timer >= 0)
        {
            timerText.text = "Start mashing in..." + Mathf.Round(timer);
        }
        else 
        {
            timerText.text = "Press Space to Restore Health!";
            shouldHeal = true;
            damageTimer -= 0.1f;

            //Check if the Damage Timer is above 0.
            //If not, stop dealing damage and disable the healing function
            if (damageTimer >= 0)
            {
                DealDamage(0.5f);
            }
            else
            {
                shouldHeal = false;
                Debug.Log("Stopped dealing damage");
            }

            //Alternatively, if the player dies before the timer runs out, stop the healing function as well.
            if (currentHealth <= 0)
            {
                shouldHeal = false;
            }
          
        }

        if (Input.GetKeyDown(KeyCode.Space) && shouldHeal == true)
        {
            RestoreHealth(3);
        }
       
	}


    void DealDamage(float damageValue)
    {


        //Deal damage to the health bar
        currentHealth -= damageValue;
        //Same as from start
        healthBar.value = CalculateHealth();

        //If the character is out of health, they die
        if (currentHealth <= 0)
        {
            Die("GameOver");
        }
            
    }

    void RestoreHealth(float healthGained)
    {
        Debug.Log("Healing");
        //Deal damage to the health bar
        currentHealth += healthGained;
        healthBar.value = CalculateHealth();

        //Prevent the player from restoring full health
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

    void Die(string gameOver)
    {
        currentHealth = 0;
        levelToLoad = gameOver;
        animator.SetTrigger("FadeOut");
        Debug.Log("Transition to game over scene, then reload");
    }

    //This function is called upon via Animation Events!
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}

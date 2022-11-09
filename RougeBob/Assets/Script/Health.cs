using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
       public int maxHealth = 3; 
    public int currentHealth;
    public float deathDelay;




    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;//losing health
        Debug.Log("Player Health =" + currentHealth);

             if(currentHealth <= 0)
            {
              Debug.Log("Player have Died! Game Over!");//game over
              Time.timeScale = 0f;
            }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount; //healing

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}

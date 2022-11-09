using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
       public int maxHealth = 3; 
    public int currentHealth;
    public float deathDelay;




    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;//Set current health
    }


    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;//take away enemey health
        Debug.Log("Enemies Health =" + currentHealth);

             if(currentHealth <= 0)
            {
              Debug.Log("Enemy has Died!");//check to see if the enmey has expired
              Destroy(gameObject,deathDelay);
            }
    }
  
}
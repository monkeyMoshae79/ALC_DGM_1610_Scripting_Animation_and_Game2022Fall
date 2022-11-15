using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdd : MonoBehaviour
{
    private Health playerHealth;
    private Transform chest;

    // Start is called before the first frame update
    void Start()
    {
        //chest = GameObject.FindGameObjectWithTag("Chest").GetComponent<Transform>;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
     {
        if(other.gameObject.CompareTag("Player"))
        {

        }
     }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pickup
{
    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //pickup key
        if(other.gameObject.CompareTag("Player"))
        {
            gm.AddKey(amount);// Add pickup to inventory
            Destroy(gameObject);//Destroy pickup item
        
        }
    }

}

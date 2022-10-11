using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private GameManager gm; //GameManager script
    public float doorDelay = 0.5f; //How long will take to open door
   
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); // Find GameManager object than reference script component
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && gm.key >= 1 ) // && mean two condentions
        {
            Destroy(gameObject, doorDelay);
            gm.key --; //subracted one key
            // Trouble shooting feedback
            Debug.Log("Keys = " + gm.key); //Tell how many keys have left
            Debug.Log("Door is open!"); //Door open

        }
        else
        {
            Debug.Log("Door is locked, You need a key!");
        }
        
    }
}

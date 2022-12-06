using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private GameManager gm;
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); //Find and reference GameManger
        rend = GetComponent<Renderer>();
        rend.enabled = true; //Make the flag visible
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) //Chekcing if player is colliding with the object.
        {
            gm.hasFlag = true;
            Debug.Log("You have captured the flag!");
            //this.gameobject.SetActive(false);
            rend.enabled = false; //Hides the Flag
        }
    }
}

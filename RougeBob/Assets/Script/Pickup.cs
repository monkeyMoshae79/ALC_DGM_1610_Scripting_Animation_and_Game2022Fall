using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public  string names;
    public string typeOfPickup;
    public string description;

    public int amount;
    public int value;

    private GameManager gm;

    // Start is called before the first frame update
    void Start ()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Addkey(int amount)
    {

        key += amount; //Add keys to inventory
        Debuy.Log("You have "+ keys +" Keys")
    }
}

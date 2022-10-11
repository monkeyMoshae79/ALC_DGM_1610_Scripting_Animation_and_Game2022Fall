using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public int key;

   public void AddKey(int amount)
    {
        key += amount; //Add key to inventory
        Debug.Log("You have" + key + "Keys"); //Print message showing hoe many keys have in inventory
    }
}

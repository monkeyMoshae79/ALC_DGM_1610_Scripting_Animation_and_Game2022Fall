using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool hasFlag;
    public bool placedFlag;

    // Start is called before the first frame update
    void Start()
    {
        hasFlag = false;
        placedFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(placedFlag) //It the same as == true
        {
            WinGame();//once the flag has been placed at home base, the player win the game
        }
    }

    public void Placeflag()
    {
        if(hasFlag)
        {
            placedFlag = true;
            Debug.Log("The Flag has been placed at home base!");
        }
    }
    
    public void WinGame()
    {
        Debug.Log("You have won the game!");
        //Time.timeScale = 0; //Freeze time
    }
       
}


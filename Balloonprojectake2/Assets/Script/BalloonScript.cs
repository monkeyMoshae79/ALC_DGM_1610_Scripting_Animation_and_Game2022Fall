using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour

{
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale increase each time the ballon is clicked 

    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;

        //Increase ballon volume
        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            //scoreManger.IncreaseScoreText(scoreToGive);

            Destroy(gameObject);

        }
    }

}

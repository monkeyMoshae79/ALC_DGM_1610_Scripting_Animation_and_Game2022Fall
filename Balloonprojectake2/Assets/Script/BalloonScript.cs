using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour

{
    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale increase each time the ballon is clicked

    public int scoreToGive = 100; //Score give for popped balloon.

    private ScoreManager scoreManager; //a variable to reference the ScoreManger

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component
        scoreManager = GameObject.Find("ScoreManger").
        GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;

        //Increase ballon volume
        transform.localScale += Vector3.one * scaleToIncrease;

        if (clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject); //Pop Balloon

        }
    }

}

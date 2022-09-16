using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloatup : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float upperBound = 25.0f;
    private BalloonScript balloon;

    private ScoreManger scoreManger; // A varible to reference the scoreManager


    // Start is called before the first frame update
    void Start()
    {
        //Reference.ScoreManger Componet
        scoreManger = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<BalloonScript>(); //reference balloon script
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the BallonScript upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        //Destory Balloon after it passes upperbond
        if(transform.position.y > upperBound)
        {
            scoreManger.DecreaseScoreText(balloon.scoreToGive);//Substract scoreToGive from total score
            Destroy(gameObject);//POP Balloon
        }
    }
}

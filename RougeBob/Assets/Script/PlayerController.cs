using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // speed
    private float hInput; //horixontal movement
    private float vInput; //vertical movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector2.right * hInput * speed * Time.deltaTime);// move left and right
       //Alt way write Vector2.right: Vector(speed,0)

        transform.Translate(Vector2.up * vInput * speed * Time.deltaTime); // Move forward and back
        //alt way write Vector2.up: Vector(0,speed)

    }
}

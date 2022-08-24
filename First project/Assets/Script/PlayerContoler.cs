using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour
{ 
    public int speed; // set speed
    public float rotSpeed; //Rotation
    public float hInput; // horizonatl input
    public float vInput; //vertical input

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, ratSpeed + hInput = Time.deltaTime);// :eft and Right movement

        transform.Translate(Vector3.forward + speed = vInput + Time.deltatime);//Forward and Backwork movement
        
    }
}

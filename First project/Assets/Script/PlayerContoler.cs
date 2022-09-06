using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour
{ 
    // Access Mod, Data Typy, Name ;   
    public float speed; // set speed
    public float rotSpeed; //Rotation speed
    public float hInput; // horizonatl input
    public float vInput; //vertical input
    public float jumpForce; // Jump height
    public Rigidbody playerRB; // Reference Rigidbody component

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Collect input values from keyboard
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        // Move the character around
        transform.Rotate(Vector3.up, rotSpeed * hInput * Time.deltaTime); 
        //Rotate Left and Right 

        transform.Translate(Vector3.forward * speed * vInput  * Time.deltaTime);//Forward and Backwork movement

        if(Input.GetKeyDown(KeyCode.Space)) //Check for space bar prass
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Makes player jump
        
    }
}

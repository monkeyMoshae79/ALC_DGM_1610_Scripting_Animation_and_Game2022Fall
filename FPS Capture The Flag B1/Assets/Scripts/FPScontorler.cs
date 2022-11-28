using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontorler : MonoBehaviour
{
    //Global Variabls 
    [Header("Player Stats")]
    public float moveSpeed;//movement speed in units per second. 
    public float jumpForce;//force applied to the y axis to make the player jump up
    
    [Header("Camera Info'")]
    public float lookSensitivity;//mouse look sensitivity 
    public float maxLookX;// lowest point we can look down
    public float minLookX;// hight point we can look up
    public float rotX;//roation of the camera
    [Header("Private Variables")]
    private Camera camera;// reference the main camera
    private Rigidbody rb;// reference the rigibbody componet 

    void Awake()
    {
        //Get Componets
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
    void PlayerMove()
    {
        //float x = Input.GetAxis("Horizontal") GetButton("Fire") GetKey(KeyCode.F) GetKeyDown GetKeyUp
        float x = Input.GetAxis("Horizontal") * moveSpeed; // get right and left input
        float z = Input.GetAxis("Vertical") * moveSpeed; // get forward and backwards input

        rb.velocity = new Vector3(x,rb.velocity.y,z); //Applys velocity on x and z axes. It make the player move
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

    }


}  



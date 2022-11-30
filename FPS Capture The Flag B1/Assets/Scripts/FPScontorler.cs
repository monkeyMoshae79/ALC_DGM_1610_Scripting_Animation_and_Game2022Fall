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
    private float rotX;//roation of the camera
    [Header("Private Variables")]
    private Camera camera;// reference the main camera
    private Rigidbody rb;// reference the rigibbody componet 

    void Awake()
    {
        //Get Componets
        camera = Camera.main;
        rb = GetComponent<Rigidbody>();
        //freeze/ and disable cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraLook();

        if(Input.GetButtonDown("Jump"))
            PlayerJump();
    }
    void PlayerMove()
    {
        //float x = Input.GetAxis("Horizontal") GetButton("Fire") GetKey(KeyCode.F) GetKeyDown GetKeyUp
        float x = Input.GetAxis("Horizontal") * moveSpeed; // get right and left input
        float z = Input.GetAxis("Vertical") * moveSpeed; // get forward and backwards input
        //move the play  in relation to the cameras direction. 
        Vector3 dir = transform.right * x + transform.forward * z;
        dir.y = rb.velocity.y;

        rb.velocity = dir; //Applys velocity on x and z axes. It make the player move
    }

    void CameraLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;

                            //roation x, and two values it restreating motion
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX); //clamp the vertiacl rotation of the player so it dosen't flip around.
        //applied rotation to the player
        camera.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    void PlayerJump()
    {   //ray cast for ground detection         //.postion is starting point/player position
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 1.1f))
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        
    }
}  

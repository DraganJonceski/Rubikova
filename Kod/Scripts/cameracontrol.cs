using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour
{
    //rotation
    
    public float speedH = 2.0f;
    public float speedV = 2.0f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
   
    //wasd
    float speed = .04f;
    // Start is called before the first frame update
    void Start()
    {

    }

   

    // Update is called once per frame
    void Update()
    {   
        //wasdspace
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        transform.position += moveDirection * speed;
     
        if (Input.GetKey(KeyCode.Space))
            transform.position += new Vector3(0.0f, 0.04f, 0.0f);
        else if(Input.GetKey(KeyCode.L))
             transform.position -= new Vector3(0.0f, 0.04f, 0.0f);

        //rotation
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


    }
}

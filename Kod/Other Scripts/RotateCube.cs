using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    //public Transform white;
    public Transform green    ;
    public Transform blue;
   // public Transform red;
   // public Transform orange;
    //public Transform yellow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            blue.Rotate(Vector3.back,150*Time.deltaTime);
        }
        else  if (Input.GetKey(KeyCode.B))
        {
            green.Rotate(Vector3.forward,150*Time.deltaTime);
        }
    }
}


using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   
    public Transform topTransform;
    public Transform centerTransform;
    public Transform bottomTransform;
    
    public Transform[] frontTransform;
    public Transform[] centerVertical;
    public Transform[] backTransform;
  
    void Start()
    {
        
    }
    private float _rotationspeed = 150f;
 


  
    private void Update()
    {
       // Debug.Log( frontTransform[0].rotation.z %90);
       if (Input.GetKey(KeyCode.U) )
       {
      
          topTransform.RotateAround(new Vector3(1f, 0, 1.5f), Vector3.up, _rotationspeed  *Time.deltaTime);
           
           // Debug.Log(topTransform.localRotation.z % 90);
       } 
        if (Input.GetKey(KeyCode.N) )
       {
           bottomTransform.RotateAround(new Vector3(1f,0,1.5f), Vector3.up, _rotationspeed* Time.deltaTime);
       }
        
        if (Input.GetKey(KeyCode.C) )
        {
            centerTransform.RotateAround(new Vector3(1f, 0, 1.5f), Vector3.up, _rotationspeed* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.F) )
        {
           
           frontTransform[0].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
           frontTransform[1].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
           frontTransform[2].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.B) )
       {
           backTransform[0].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
           backTransform[1].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
           backTransform[2].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime); 
       }
        if (Input.GetKey(KeyCode.V))
       {
           centerVertical[0].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
           centerVertical[1].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime);
           centerVertical[2].RotateAround(new Vector3(1f, 4.5f, 0f), Vector3.back, _rotationspeed* Time.deltaTime); 
       } 
        
     
   
     
   }
    
    private void FixedUpdate()
    {
        
    }
}

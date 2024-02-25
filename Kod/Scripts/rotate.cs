using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Transform centerTransform;
    // Start is called before the first frame update
    void Start()
    {
        centerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
         
            //transform.RotateAround(new Vector3(5,3,2),1.5f *Time.deltaTime);
        }
    }
}

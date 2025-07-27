using UnityEngine;


public class CubeMove : MonoBehaviour
{
   
    private GameObject _quad;
    //public Transform centers;
    //private Transform _cubeTransform;
    public Transform _frontTransform;

    public Transform fronRotation;
    //private float _angle;
   
    // Start is called before the first frame update
    void Start()
    {
        
       
        
         _quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
         //_quad.transform.SetPositionAndRotation(new Vector3(2.35f, 3.5f, 0.5f), Quaternion.Euler(0, -90, 0));
         _quad.GetComponent<Renderer>().material.color= Color.blue;
        
        
    }

    // Update is called once per frame
    void Update()
    {

    //    Vector3 _vect = new Vector3(_rectTransform.pivot.x, 0,0);
        if (Input.GetKey(KeyCode.F))
        {
         
          //_frontTransform.RotateAround(Vector3.right,15f *Time.deltaTime);
        }
    }
}

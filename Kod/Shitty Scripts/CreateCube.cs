using UnityEngine;
using UnityEngine.Serialization;

public class CreateCube : MonoBehaviour
{ 
    
    // public GameObject cubeCreator;
   // GameObject[,,] cubeArray = new GameObject[3,3,3];
   
    public float cubeSize = 3f;
    public GameObject prefab;
// Amount of layers/dimensions e.g. 3x3
    public int dimensions = 3;

    public void SpawnCube(int x, int y, int z)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z) - Vector3.one * dimensions / 2f;
        //  var cube = Instantiate (prefab, (new Vector3(x,y,z) - Vector3.one * dimensions / 2f) * cubeSize, Quaternion.identity);
        // Or whatever you want to do with the type
        // cube.GetComponent<Renderer>().material.color = colors[type];
    }
    
    
    void Start ()
    {
        
        
      /*  for(int x=0; x<3; x++)
        {
            for(int y=0; y<3; y++)
            {  
                for(int z=0; z<3; z++)
                {  
                    print("X:"+x);
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.position = new Vector3(0, 0.5f, 0);
                  //  cubeArray[x,y,z] = (GameObject)Instantiate (cubeCreator, new Vector3(x*2,y*2, z*2), transform.rotation);
                }
            }
        }*/
    }
 
   /* [SerializeField] private GameObject side;
    [SerializeField] private GameObject corner;
    private int _ypos = 1;
    private float _xpos;
    private int _zpos = 1;
    private Vector3 cornerPos;
    private Vector3 sidePos;
    
    private void Start()
    {
        cornerPos= corner.transform.position;
        sidePos = side.transform.position;
        for (var i = 0; i < 3; i++)
        {
            
            if (i % 2 == 0)
            {
                Instantiate(corner, cornerPos, Quaternion.identity);
            }
            else
            {
                Instantiate(side, sidePos, Quaternion.identity);
            }

            
                _zpos++;

            _xpos++;
            cornerPos = new Vector3(_xpos, _ypos, _zpos);
            sidePos = new Vector3(_xpos, _ypos, _zpos);
        }



        // _ypos++;
        
    }
*/
}

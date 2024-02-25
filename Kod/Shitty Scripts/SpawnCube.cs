using UnityEngine;


public class SpawnCube : MonoBehaviour
{
    private int indColor;
    private Color color = Color.blue;
    public GameObject corners;
    public GameObject sides;
    private int cornerRotation = 0;
   // public Transform[] centerTransforms = new Transform[6];
    private void Start()
    {
     
     //float rotationPosAdjustment = 0;
     float xpos = -1,zpos =-1;
     for (var i = 0; i < 3; i++)
     {
      if (i == 1)
      {
       //second row
 //center left side set
       GameObject leftSide = Instantiate(sides, new Vector3(-1.5f, 2, 0.5f), Quaternion.Euler(0,90,0));
        //lower center set
       GameObject centerQuad = GameObject.CreatePrimitive(PrimitiveType.Quad);
       centerQuad.transform.SetPositionAndRotation(new Vector3(0, 3, 0.5f), Quaternion.Euler(-90, 0, 0));
       centerQuad.GetComponent<Renderer>().material.color = Color.yellow;
       //center right side set
       GameObject rightSide = Instantiate(sides, new Vector3(1.5f, 2, 0.5f), Quaternion.Euler(0, -90, 0));
    
       //colors
       color = Color.green;
       leftSide.transform.GetChild(0).GetComponent<Renderer>().material.color = color;
       color = Color.blue;
       rightSide.transform.GetChild(0).GetComponent<Renderer>().material.color = color;
       //adjust position for next row
       xpos *= -1;
       zpos = 1.5f;
       cornerRotation = 90;
       color = Color.green;
       
      }
      else
      {
     //first  and third row
       GameObject leftCorner = Instantiate(corners, new Vector3(xpos, 2, zpos), Quaternion.Euler(0,cornerRotation,0));
       GameObject side = Instantiate(sides, new Vector3(0, 2, -1), Quaternion.identity);
       
       GameObject rightCorner = Instantiate(corners, new Vector3(1.5f, 2, -0.5f), Quaternion.Euler(0,cornerRotation,0));
       rightCorner.transform.GetChild(0).GetComponent<Renderer>().material.color = color;
       if (i == 0)
       {
        cornerRotation = -90;
        xpos = 1.5f;
        zpos = -0.5f;
        color = Color.red;
       }
       else
       {
        color = Color.magenta;
       }
       
       rightCorner.transform.GetChild(1).GetComponent<Renderer>().material.color = color;
      
     
      

      }
     }
    }
            

}


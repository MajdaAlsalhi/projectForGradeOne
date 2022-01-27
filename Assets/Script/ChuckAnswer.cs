using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuckAnswer : MonoBehaviour
{
   public GameObject square, circle, triangle, true1;
    public Material[] material;
    public Material sq;


    // Start is called before the first frame update
    void Start()
    {
        // square = GameObject.FindWithTag("Square");
      
       //square=GetComponent<Renderer>().material;
       // circle = GameObject.FindWithTag("Circle");
       // triangle = GameObject.FindWithTag("Triangle");

     //   true1 = GameObject.FindWithTag("True");
    }

    private void Update()
    {  
        sq = square.GetComponent<Renderer>().material;
       // print(material[3]);
        chuck();
    }

    void chuck() { 
    
      if (sq == material[3]) //&& circle.GetComponent<Renderer>().sharedMaterial == material[1] && triangle.GetComponent<Renderer>().sharedMaterial == material[2])
        {
            print("goooooooooooooooo");

           //true1.SetActive(true);
        }
    
    }
    }

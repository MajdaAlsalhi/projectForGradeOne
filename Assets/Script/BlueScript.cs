using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScript : MonoBehaviour
{

    public Material [] material;
    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Blue") 
        { 
            rend.sharedMaterial = material[1];
            
        }
        if (col.gameObject.tag == "Red")
        {
            rend.sharedMaterial = material[2];
        }
        if (col.gameObject.tag == "Yellow")
        {
            rend.sharedMaterial = material[3];
        }
    }
}

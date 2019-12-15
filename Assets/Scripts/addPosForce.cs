using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class addPosForce : MonoBehaviour
{
    private Transform other;
    public ForceMode mode;
    public float factor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
        

  
    private void OnTriggerStay(Collider other)
    {
        Vector3 g = (transform.position - other.transform.position) * factor; 
        other.gameObject.GetComponent<Rigidbody>().AddForce(g,mode);
    }
   
}

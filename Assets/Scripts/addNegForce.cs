using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addNegForce : MonoBehaviour
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
        Vector3 g = (other.transform.position - transform.position) * factor;
        other.gameObject.GetComponent<Rigidbody>().AddForce(g, mode);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addTangentForce : MonoBehaviour
{
    public float factorVelocity;
    public float factorTangent;
    public ForceMode mode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider col)
    {
        Rigidbody rigidBody = col.gameObject.GetComponent<Rigidbody>();
        rigidBody.velocity = rigidBody.velocity * factorVelocity;
        Vector3 g = (transform.position - col.transform.position) * factorTangent;
        rigidBody.AddForce(g, mode);
    }
}

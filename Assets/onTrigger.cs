using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTrigger : MonoBehaviour
{
    private List<GameObject> hitList;
    public GameObject earth;
   
    private void Start()
    {
        hitList = new List<GameObject>();
    }

    private void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote) || Input.GetKeyDown("s"))
        {
            Debug.Log("shoot");
            //earth.GetComponent<Renderer>().material.color=new Color(255,0,0);
            for (int i = 0; i < hitList.Count; i++)
            {
                Destroy(hitList[i]);

            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            //OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote
            hitList.Add(col.gameObject);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Asteroid")
        {
            //
            hitList.Remove(col.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingAnim : MonoBehaviour
{
    // Start is called before the first frame update
    public LineRenderer asdf;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote))
        {
            asdf.enabled = true;
        }

        else if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTrackedRemote))
        {
            asdf.enabled = false;
        }
    }
}

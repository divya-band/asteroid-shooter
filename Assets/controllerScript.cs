using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class controllerScript : MonoBehaviour
{
    public GameObject forceField;
    public GameObject gravityField;
    public GameObject rotationField;
    public GameObject exploder;
    public GameObject laser;
    public bool isOnForce = false;
    public bool isOnGravity = false;
    public bool isOnRotation = false;
    public bool isOnExploder = false;

    // Start is called before the first frame update
    void Start()
    {
        // returns true if right-handed controller connected
        //OVRInput.IsControllerConnected(OVRInput.Controller.RTrackedRemote);

        //turn off all the fields to begin
        forceField.SetActive(false);
        gravityField.SetActive(false);
        rotationField.SetActive(false);
        exploder.SetActive(false);
        //bool isOn = false; 
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad, OVRInput.Controller.RTrackedRemote);

        //float trigger = OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger);
        //float up = OVRInput.Get(OVRInput.Button.);
        //float down = 

        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            Vector2 primaryTouchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            if (primaryTouchpad.x > .75f )
            {
                if(isOnRotation)
                {
                    rotationField.SetActive(true);
                   isOnRotation = false;
                }
                else
                {
                    rotationField.SetActive(false);
                    isOnRotation = true;
                }
                

            }

            else if (primaryTouchpad.x < -.75f )
            {
                if (isOnExploder)
                {
                    exploder.SetActive(true);
                    isOnExploder = false;
                }
                else
                {
                    exploder.SetActive(false);
                    isOnExploder = true;
                }
                
            }

            if (primaryTouchpad.y > .75f )
            {
                if (isOnForce)
                {
                    forceField.SetActive(true);
                    isOnForce = false;
                }
                else
                {
                    forceField.SetActive(false);
                    isOnForce = true;
                }
               
            }

            else if (primaryTouchpad.y < -.75f )
            {
               
                if (isOnGravity)
                {
                    gravityField.SetActive(true);
                    isOnGravity = false;
                }
                else
                {
                    gravityField.SetActive(false);
                    isOnGravity = true;
                }
            }


        }

        
    }
}

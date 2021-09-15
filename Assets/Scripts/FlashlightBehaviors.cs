using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class FlashlightBehaviors : GrabbableEvents
{
   
    public override void OnGrab(Grabber grabber)
    {
       
        Debug.Log("Flashlight Picked Up");
        GameObject flashlight = GameObject.Find("/Flashlight/WhiteLight");
        Light light = flashlight.GetComponent(typeof(Light)) as Light;
        light.intensity = 2.1f;
        base.OnGrab(grabber);
    }

    public override void OnRelease()
    {
        
        Debug.Log("Flashlight Released");
        GameObject flashlight = GameObject.Find("/Flashlight/WhiteLight");
        Light light = flashlight.GetComponent(typeof(Light)) as Light;
        light.intensity = 0.0f;
        base.OnRelease();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using BNG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Flashlight))]
public class FlashlightBehaviors : GrabbableEvents
{
    public Flashlight flashlight;

    public override void OnGrab(Grabber grabber)
    {
        Debug.Log("Flashlight Picked Up");
        flashlight = GetComponent<Flashlight>();
        flashlight.SpotLight.intensity = 2.1f;
        base.OnGrab(grabber);
    }

    public override void OnRelease()
    {
        Debug.Log("Flashlight Released");
        flashlight = GetComponent<Flashlight>();
        flashlight.SpotLight.intensity = 0.0f;
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

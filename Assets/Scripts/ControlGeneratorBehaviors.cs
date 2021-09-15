using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;


public class ControlGeneratorBehaviors : MonoBehaviour
{

    //These are reversed for some reason, so up is down.
    public void LeverUp()
    {
        Debug.Log("Switch on");
        GameObject utillight = GameObject.Find("/UtilityRoom/ELightUtilRoom/Cylinder/SpotLight");
        if (utillight)
        {
            Debug.Log("Light Found");
            Light lightbulb = utillight.GetComponent<Light>();
            lightbulb.intensity = 0;
        }
    }

    //These are reversed for some reason, so down is up.
    public void LeverDown()
    {
        Debug.Log("Switch off");
        GameObject utillight = GameObject.Find("/UtilityRoom/ELightUtilRoom/Cylinder/SpotLight");
        if (utillight)
        {
            Light lightbulb = utillight.GetComponent<Light>();
            lightbulb.intensity = 1;
        }
    }

}

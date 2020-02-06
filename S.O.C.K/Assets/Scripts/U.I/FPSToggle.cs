using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSToggle : MonoBehaviour
{

    //Pressing F7 will either toggle the FPSCounter on or off
    void Update()
    {
        if(Input.GetKey(KeyCode.F7) && FPSButton.fpsOn == false)
        {
            FPSButton.fpsOn = true;
        }
        else if(Input.GetKey(KeyCode.F7) && FPSButton.fpsOn == true)
        {
            FPSButton.fpsOn = false;
        }
    }
}

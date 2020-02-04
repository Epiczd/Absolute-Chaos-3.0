using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

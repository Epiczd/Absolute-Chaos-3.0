using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSButton : MonoBehaviour
{
    public static bool fpsOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void Update()
   {
        
   }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && fpsOn == false)
        {
            fpsOn = true;
        }
        else if (Input.GetMouseButtonDown(0) && fpsOn == true)
        {
            fpsOn = false;
        }
    }
}

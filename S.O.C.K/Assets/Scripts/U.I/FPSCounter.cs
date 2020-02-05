using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    //FPSCounter GameObject
    public GameObject fpsCounter;

    //Checkmark in the settings menu
    public GameObject check;

    //The FPS text on screen
    public TextMesh FPS;

    /* FPS.text tells the text to display the current frames per second in the text mesh FPS.
     * If fpsOn = true, the fps counter will be displayed,
     * If it is false, the fps counter will NOT be displayed
     */
    void Update()
    {
        FPS.text = "FPS: " + 1f / Time.unscaledDeltaTime;

        if(FPSButton.fpsOn == true)
        {
            fpsCounter.SetActive(true);
            check.SetActive(true);
        }
        else
        {
            fpsCounter.SetActive(false);
            check.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public GameObject fpsCounter;

    public GameObject check;

    public TextMesh FPS;

    // Start is called before the first frame update
    void Start()
    {
        FPS = (TextMesh)GameObject.Find("FPS Counter").GetComponent<TextMesh>();
    }

    // Update is called once per frame
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{

    private bool fullscreen;

    public GameObject check;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(fullscreen);

        if(fullscreen == true)
        {
            Screen.fullScreen = true;
            check.SetActive(true);
        }
        else
        {
            Screen.fullScreen = false;
            check.SetActive(false);
        }
    }

    void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0) && fullscreen == false)
        {
            fullscreen = true;
        }
        else if(Input.GetMouseButtonDown(0) && fullscreen == true)
        {
            fullscreen = false;
        }
    }
}

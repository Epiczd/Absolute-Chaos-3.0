using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitToDesktop : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}

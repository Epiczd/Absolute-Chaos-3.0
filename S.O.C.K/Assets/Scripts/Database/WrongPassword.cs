using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongPassword : MonoBehaviour
{
    public Text WrongPass;
    void Start()
    {
        WrongPass.enabled = false;
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            WrongPass.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitToDesktop : MonoBehaviour
{
    public Button Quit;
   void Start()
    {
        Quit.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Application.Quit();
    }
}

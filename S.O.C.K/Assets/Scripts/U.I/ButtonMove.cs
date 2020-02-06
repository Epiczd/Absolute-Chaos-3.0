using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMove : MonoBehaviour
{
    //Button
    public Button TaskButton;

    //Name of requested scene
    public string SceneName;
    
    //Required for the button to work
   void Start()
   {
       TaskButton.onClick.AddListener(taskOnClick);
   }
    // If the player pressed the button, it loads the new scene
   void taskOnClick()
   {
       SceneManager.LoadScene(SceneName);
   }
}

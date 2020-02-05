using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMove : MonoBehaviour
{
    public Button TaskButton;
    public string SceneName;
   void Update(){
       TaskButton.onClick.AddListener(taskOnClick);
   }
   void taskOnClick(){
       SceneManager.LoadScene(SceneName);
   }
}

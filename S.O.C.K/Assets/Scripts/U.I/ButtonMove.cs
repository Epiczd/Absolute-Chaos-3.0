using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMove : MonoBehaviour
{
    public string SceneName;
  void OnMouseDown(){
      if(Input.GetMouseButtonDown(0)){
          SceneManager.LoadScene(SceneName);
      }
  }
}

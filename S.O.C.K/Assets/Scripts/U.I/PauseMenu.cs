using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
 public GameObject Pausepanel;
 public static bool gamepaused;
 void Start(){
     Pausepanel.SetActive(false);
 }
  void Update(){
     if(Input.GetKeyDown(KeyCode.Escape) && gamepaused == false){
        PausedGame();
     }else if(Input.GetKeyDown(KeyCode.Escape) && gamepaused == true){
         ResumeGame();
     }
 }
 void PausedGame(){
     Time.timeScale = 0;
     gamepaused = true;
     Cursor.visible = true;
     Pausepanel.SetActive(gamepaused);
 }
 void ResumeGame(){
    Time.timeScale = 1;
    Cursor.visible = false;
    gamepaused = false;
    Pausepanel.SetActive(gamepaused);
 }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpause : MonoBehaviour
{
   void OnMouseDown(){
       if(Input.GetMouseButtonDown(0)){
           Time.timeScale = 1;
           Cursor.visible = true;
       }
   }
}

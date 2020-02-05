using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoreDatabaseUser : MonoBehaviour
{
   public InputField UserName;
   public InputField Password;
   public Button CreateUserButton;

   Dbmanager dataManager = Dbmanager.Instance;
   void Start(){
      CreateUserButton.onClick.AddListener(TaskOnClick);
   }
   void TaskOnClick(){
        if(UserName.text != DatabasePlayerStuff.usernameFromDb && Password.text != DatabasePlayerStuff.userpaswordFromDb){
            string insertThis = string.Format("INSERT INTO PlayerDatabase(Username, UserPassword) VALUES('{0}','{1}')",UserName.text, Password.text);
            dataManager.normalDbComand(insertThis);
            DatabasePlayerStuff.LoggedIn = true;
       }
      
   }
}

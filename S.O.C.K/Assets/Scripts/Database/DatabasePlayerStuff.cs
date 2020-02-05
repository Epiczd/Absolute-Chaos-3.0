using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DatabasePlayerStuff : MonoBehaviour
{
   Dbmanager dataManager = Dbmanager.Instance;
    public static string usernameFromDb;
    public static string userpaswordFromDb;
    public static string UserName;
    public static int UserCredits;
    string UserPassword;
    public InputField UserNameInput;
    public InputField UserPasswordInput;
    public Button LoginButton;
    public static bool LoggedIn;
    void Start(){
        LoginButton.onClick.AddListener(TaskOnClick);
        dataManager.GettingUserStuff("SELECT*FROM PlayerDatabase");
    }
    void Update(){
       
    }
    void TaskOnClick(){
        UserName = UserNameInput.text;
        UserPassword = UserPasswordInput.text;
        if(UserName == usernameFromDb && UserPassword == userpaswordFromDb ){
            LoggedIn = true;
            SceneManager.LoadScene("Title");
        }
    }
}

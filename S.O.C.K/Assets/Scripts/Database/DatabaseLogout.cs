using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatabaseLogout : MonoBehaviour
{
    public Button LogoutButton;
    void Start()
    {
        LogoutButton.onClick.AddListener(TaskOnClick);
    }
    void Update(){
        if(DatabasePlayerStuff.LoggedIn == false)
        {
            LogoutButton.enabled = false;
        }else if(DatabasePlayerStuff.LoggedIn == true)
        {
            LogoutButton.enabled = true;
        }
    }
    void TaskOnClick()
    {
        DatabasePlayerStuff.LoggedIn = false;
    }
}

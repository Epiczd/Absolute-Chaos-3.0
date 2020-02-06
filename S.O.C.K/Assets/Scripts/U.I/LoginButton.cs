using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginButton : MonoBehaviour
{
    public Button LoginButtonC;
    public Text ButtonText;
    // Start is called before the first frame update
    void Update()
    {
        if(DatabasePlayerStuff.LoggedIn == true)
        {
            ButtonText.text = DatabasePlayerStuff.UserName;
            LoginButtonC.enabled = false;
        }else if(DatabasePlayerStuff.LoggedIn == false)
        {
            ButtonText.text = "Login";
            LoginButtonC.enabled = true;
        }
    }
}

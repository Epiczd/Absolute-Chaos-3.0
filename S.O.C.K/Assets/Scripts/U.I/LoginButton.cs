using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginButton : MonoBehaviour
{
    public Button LoginButtonC;
    public Text ButtonText;
    // Start is called before the first frame update
    void Start()
    {
        if(DatabasePlayerStuff.LoggedIn == true){
            LoginButtonC.enabled = false;
            ButtonText.text = DatabasePlayerStuff.UserName;
    }else{
        LoginButtonC.enabled = true;
        ButtonText.text = "Login";
    }
}
}

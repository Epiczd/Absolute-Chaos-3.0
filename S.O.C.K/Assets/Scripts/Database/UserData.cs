using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserData : MonoBehaviour
{
    Dbmanager dataManager = Dbmanager.Instance;
    public Button LoginButton;
    public InputField UserName;
    void Start()
    {
       LoginButton.onClick.AddListener(OnClickEvent);
    }
     void Update()
    {
        if(DatabasePlayerStuff.LoggedIn == true)
        {
            dataManager.LookingIntForData("SELECT*FROM AllPlayerData", 1, DatabasePlayerStuff.UserCredits);
        }
        Debug.Log(dataManager.isDataHere);
    }
    void OnClickEvent()
    {
        dataManager.DataCheck("SELECT name FROM sqlite_master WHERE name = 'AllPlayerdata'");

        if (dataManager.isDataHere != false) { 
        dataManager.normalDbComand("CREATE TABLE AllPlayerData(Username TEXT, UserCredits INT, PlayTime INT)");
            
        }
        dataManager.GettingUserStuff("SELECT*FROM AllPlayerData");
        if (UserName.text != DatabasePlayerStuff.usernameFromDb)
            {
                string insertThis = string.Format("INSERT INTO AllPLayerData(Username,UserCredits,PlayTime) VALUES('{0}', '0','0')", UserName.text);
                dataManager.normalDbComand(insertThis);
            }
        
    }
}

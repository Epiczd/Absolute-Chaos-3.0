using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreTables : MonoBehaviour
{
   Dbmanager dataManager = Dbmanager.Instance;
   void Start(){
       dataManager.DataCheck("SELECT*FROM PlayerDatabase");
       if(dataManager.isDataHere == false){
           dataManager.normalDbComand("CREATE TABLE PlayerDatabase(Username TEXT, UserPassword TEXT)");
       }
   }
}

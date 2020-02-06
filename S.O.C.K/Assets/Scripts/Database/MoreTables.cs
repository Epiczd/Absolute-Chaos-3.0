using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreTables : MonoBehaviour
{
   Dbmanager dataManager = Dbmanager.Instance;
   void Start(){
       dataManager.DataCheck("SELECT name From sqlite_master WHERE name ='PlayerDatabase'");
       if(dataManager.isDataHere != true){
           dataManager.normalDbComand("CREATE TABLE PlayerDatabase(Username TEXT, UserPassword TEXT)");
       }
   }
}

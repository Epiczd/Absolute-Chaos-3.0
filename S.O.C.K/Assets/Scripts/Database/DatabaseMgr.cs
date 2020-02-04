using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class Dbmanager{
    private static Dbmanager DbMgr;
    private Dbmanager(){

    }
    public static Dbmanager Instance{
        get{
            if(DbMgr == null){
                DbMgr = new Dbmanager();
            }
            return DbMgr;
        }
    }
    public string connectionString = "Data Source = SockData.db";
    public void normalDbComand(string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
                dbCmd.ExecuteNonQuery();
            }
        }
    }
}
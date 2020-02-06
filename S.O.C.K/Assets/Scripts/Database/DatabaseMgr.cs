using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System;

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
    public bool isDataHere;
    public string connectionString = "Data Source = SockData.db";
    public void normalDbComand(string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
                dbCmd.ExecuteNonQuery();
            }
        }
    }
    public void getShopStuff(string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    while(dbReader.Read()){
                        ShopManager.ItemName = dbReader[1].ToString();
                        ShopManager.ItemPrice = Convert.ToInt32(dbReader[2]);
                        ShopManager.ItemId = Convert.ToInt32(dbReader[0]);
                    }
                }
            }
        }
    }
    public void DataCheck(string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand  dbCmd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    if(!dbReader.Read()){
                        isDataHere = false;
                    }else{
                        isDataHere = true;
                    }
                }
            }
        }
    }
    public void ReaderCheck(string commandText , int readerindex){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText,dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    if(!dbReader.Read()){
                        Debug.Log("ERROR!: No Data Found at That Reader Index.");
                    }else{
                        Debug.Log("SUCCESS!: Here's What was Found: " + dbReader[readerindex].ToString());
                    }
                }
            }
        }
    }
    public void GettingUserStuff(string commandText){
        using(SqliteConnection dbCon = new SqliteConnection(connectionString)){
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon)){
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader()){
                    while(dbReader.Read()){
                      DatabasePlayerStuff.usernameFromDb = dbReader[0].ToString();
                        DatabasePlayerStuff.userpaswordFromDb = dbReader[1].ToString();
                    }
                }
            }
        }
    }
    public void LookingIntForData(string commandText,int ReaderIndex, int IntVar )
    {
        using(SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        IntVar = Convert.ToInt32(dbReader[ReaderIndex]);
                    }
                }
            }
        }
    }
    public void LookingForStringData(string commandText, int readerIndex, string StringVar)
    {
        using(SqliteConnection dbCon = new SqliteConnection(connectionString))
        {
            dbCon.Open();
            using(SqliteCommand dbCmd = new SqliteCommand(commandText, dbCon))
            {
                using(SqliteDataReader dbReader = dbCmd.ExecuteReader())
                {
                    while (dbReader.Read())
                    {
                        StringVar = dbReader[readerIndex].ToString();
                    }
                }
            }
        }
    }
}
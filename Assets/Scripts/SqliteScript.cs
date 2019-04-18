using UnityEngine;
using System;
//using Mono.Data.Sqlite;

public class SqliteScript : MonoBehaviour
{
    /*
    protected SqliteConnection dbconn;
    SqliteCommand cmd;
    void Awake()
    {
        if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            dbconn = new SqliteConnection("URI=file:" + Application.dataPath + "/../Data.db");
        }
        else
        {
            dbconn = new SqliteConnection("URI=file:" + Application.dataPath + "/Data.db");
        }

        dbconn.Open();
        
        try
        {
            cmd = new SqliteCommand("SELECT speed FROM snake", dbconn);
            SqliteDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int speed = reader.GetInt32(0);
                    Debug.Log(speed);
                }
            }

            reader.Close();
            reader = null;
        }
        catch
        {
            Debug.Log("Error reading DB");
        }

        cmd.Dispose();
        cmd = null;
        dbconn.Close();
        dbconn = null;


    }
    */
}

using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SavePlayerAuto (PlayerScript player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/AutoSave.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Successful Save In " + path);
    }

    public static PlayerData LoadPlayerAuto()
    {
        string path = Application.persistentDataPath + "/AutoSave.sav";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            Debug.Log("Successful Load In " + path);

            return data;
        }
        else
        {
            Debug.LogError("No Save Found In " + path);
            return null;
        }
    }

    public static void SavePlayer(PlayerScript player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/ManualSave.sav";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData2 data = new PlayerData2(player);

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Successful Save In " + path);
    }

    public static PlayerData2 LoadPlayer()
    {
        string path = Application.persistentDataPath + "/ManualSave.sav";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData2 data = formatter.Deserialize(stream) as PlayerData2;
            stream.Close();

            Debug.Log("Successful Load In " + path);

            return data;
        }
        else
        {
            Debug.LogError("No Save Found In " + path);
            return null;
        }
    }

}
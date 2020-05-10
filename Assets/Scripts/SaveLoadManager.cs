using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadManager 
{
    public static void Save(string path, PlayerInfo playerinfo)
    {
        using (var fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(fs, playerinfo);
            fs.Close();
        }
    }

    public static PlayerInfo Load(string path)
    {
        using (var fs = new FileStream(path, FileMode.Open))
        {
            var formatter = new BinaryFormatter();
            return (PlayerInfo)formatter.Deserialize(fs);
        }
    }
}

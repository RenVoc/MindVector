using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem {
    // При сохранении создаем бинарный файл и производим в него запись состояния из констрктора PlayerData.

    public static void SavePlayer (PlayerControl player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.mvs";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    // При загрузке открываем для чтения наш сохраненный бинарный файл и берем значения из сохраненного состояния data.

    public static PlayerData LoadPlayer() {
        string path = Application.persistentDataPath + "/player.mvs";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            return null;
        }
    }

}

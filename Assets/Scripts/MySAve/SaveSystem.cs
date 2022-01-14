using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    /*
     * Permet de récupérer les données du type PlayerData stockées dans de fichier score.score
     * */
    public static PlayerData LoadScore()
    {
        string path = Application.persistentDataPath + "/score.score";
        if (!System.IO.File.Exists(path))
        {
            PlayerData defautData = new PlayerData();
            return defautData;
        }
        else
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream saveFile = File.Open(path, FileMode.Open);
            PlayerData loadData = (PlayerData)formatter.Deserialize(saveFile);
            saveFile.Close();
            return loadData;
        }

        
    }


    /*
     * Permet de stocker les données du type PlayerData dans un fichier score.score
     */
    public static void SaveScore(GameManager gm)
    {
        string path = Application.persistentDataPath + "/score.score";
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream saveFile = File.Create(path);
        PlayerData data = new PlayerData(gm);
        formatter.Serialize(saveFile, data);
        saveFile.Close();


    }
}

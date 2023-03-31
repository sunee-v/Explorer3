using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class SaveSystem : MonoBehaviour
{
    private string savePath;
    private string key = "mySecretKey";
    private string encryptedJson;

    PlayerMovement playerLocation;
    // Start is called before the first frame update
    void Start()
    {
        savePath = Application.persistentDataPath + "/save.json";
    }

    
    void OnApplicationQuit()
    {
        // Serialize to JSON
        string json = JsonUtility.ToJson(playerLocation);
        encryptedJson = encryptAndDecrypt(json, key);
        //File.WriteAllText(savePath, encryptedJson);

    }
  
    public PlayerMovement Load()
    {
        //string encryptedJson = File.ReadAllText(savePath);
        string json = encryptAndDecrypt(encryptedJson, key);
        return new PlayerMovement();
    }

    private string encryptAndDecrypt(string text, string key)
    {
        var result = new StringBuilder();
        for (int c = 0; c < text.Length; c++)
            result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));
        return result.ToString();
    }
}

using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    Vector3 newpos;
    // Start is called before the first frame update
    void Start()
    {
        string json = File.ReadAllText(Application.dataPath + "/saveFile.json");
        PlayerData loadFile = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log(loadFile.pos);
       


        transform.position = loadFile.pos;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = newpos;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }
      
    }


    private class PlayerData
    {
        public Vector3 pos;
    }
    public void Save()
    {
        PlayerData Datasave = new PlayerData();
        Datasave.pos = transform.position;

        string json = JsonUtility.ToJson(Datasave);
        Debug.Log(json);
        File.WriteAllText(Application.dataPath + "/SaveFile.json", json);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File Storage Config")]

    [SerializeField] private string fileName;

    [SerializeField] private bool useEncryption;

    private GameData gameData;

    private PlayerInventory inventory;

    private GameManager gameManager;

    private List<IDataPersistence> dataPersistencesObjects;

    private FileDataHandler dataHandler;

    public static DataPersistenceManager instance { get; private set; }

    public string sfileName = "SavaData";
    public string fileExtension = ".data";


    private void Awake()
    {
        {
            if ( instance != null)
            {
                Debug.LogError("Found more than one Data Persistence Manager in the scene.");
            }  
            instance = this;
        }
    }


    private void Start()
    {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName, useEncryption);
        this.dataPersistencesObjects = FindAllDataPersistencesObjects();
        LoadGame();
    }

    public void NewGame()
    {
        File.Delete(Application.persistentDataPath + "/SaveData.data");
        this.gameData = new GameData();

    }

    public void LoadGame()
    {

        //Load any saved data from file using the data handler
        this.gameData = dataHandler.Load();

        //if no data found, sets game to defaults
        if(this.gameData == null)
        {
            Debug.Log("No data found, setting to default state");
            NewGame();

        }  

        foreach(IDataPersistence dataPersistenceObj in dataPersistencesObjects)
        {
            dataPersistenceObj.LoadData(gameData);
        }

        Debug.Log("Loaded List = " + gameData._cheese);
        Debug.Log("Loaded List = " + gameData._butter);
        Debug.Log("Loaded List = " + gameData._bread);
        Debug.Log("Loaded List = " + gameData._playerHealth);
    }

    public void SaveGame()
    {
        foreach (IDataPersistence dataPersistenceObj in dataPersistencesObjects)
        {
            dataPersistenceObj.SaveData(gameData);
        }
        Debug.Log("Saved cheese in List = " + gameData._cheese);
        Debug.Log("Saved butter in List = " + gameData._butter);
        Debug.Log("Saved bread in List = " + gameData._bread);
        Debug.Log("Loaded List = " + gameData._playerHealth);

        dataHandler.Save(gameData);
    }

    private void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistencesObjects()
    {
        IEnumerable<IDataPersistence> dataPersistenceObjects = FindObjectsOfType<MonoBehaviour>()
            .OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistenceObjects);
    }
}

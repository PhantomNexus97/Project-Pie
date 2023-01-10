using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private DataPersistenceManager _DPManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && gameObject.tag == "HUB")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("HUB");

        }

        if (other.gameObject.tag == "Player" && gameObject.tag == "HUB_Outside")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("HUB_Outside");

        }

        if (other.gameObject.tag == "Player" && gameObject.tag == "Gramps_House")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("Gramps_House");

        }

        if (other.gameObject.tag == "Player" && gameObject.tag == "HUB_Outside_Gramps")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("HUB_Outside_Gramps");

        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    private DataPersistenceManager _DPManager;
    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "HUB")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("HUB");

        }

        if (gameObject.tag == "Level01")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("Level01");

        }

        if (gameObject.tag == "Level02")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("Level02");

        }

    }

}

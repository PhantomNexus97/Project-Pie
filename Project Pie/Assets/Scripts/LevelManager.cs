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

        if (other.gameObject.tag == "Player" && gameObject.tag == "Level01")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("Level01");

        }

        if (other.gameObject.tag == "Player" && gameObject.tag == "Level02")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("Level02");

        }

        if (other.gameObject.tag == "Player" && gameObject.tag == "Level03")
        {
            DataPersistenceManager.instance.SaveGame();
            SceneManager.LoadScene("Level03");

        }

    }

}

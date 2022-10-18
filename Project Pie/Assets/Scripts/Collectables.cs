using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collectables : MonoBehaviour, IDataPersistence
{
    [SerializeField] private string id;

    [ContextMenu("Generate guid for id")]

    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    PlayerInventory inventory;

    private bool _collected = false;

    public void LoadData(GameData data)
    {
        data._itemsCollected.TryGetValue(id, out _collected);
        if (_collected)
        {
            gameObject.SetActive(false);
        }
    }

    public void SaveData(GameData data)
    {
        if (data._itemsCollected.ContainsKey(id))
        {
            data._itemsCollected.Remove(id);
        }
        data._itemsCollected.Add(id, _collected);
    }

    void OnTriggerEnter(Collider Col)
    { 
        PlayerInventory inventory = Col.GetComponent<PlayerInventory>();

        if (gameObject.tag == "Cheese" && !_collected) {
            if (inventory != null){
                inventory.AddCheese();
                gameObject.SetActive(false);
                _collected = true;
            }
        }

        if (gameObject.tag == "Butter" && !_collected)
        {
            if (inventory != null){
                inventory.AddButter();
                gameObject.SetActive(false);
                _collected = true;
            }
        }

        if (gameObject.tag == "Bread" && !_collected){
            if (inventory != null){
                inventory.AddBread();
                gameObject.SetActive(false);
                _collected = true;
            }
        }
    }


}

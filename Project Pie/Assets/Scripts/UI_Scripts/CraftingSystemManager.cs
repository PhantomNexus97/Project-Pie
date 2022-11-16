using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystemManager : MonoBehaviour
{
    public GameObject CraftingUI;
    public GameObject CraftButtonON;
    public GameObject CraftButtonOff;
    public static bool hasAmount = false;

    [Header("CraftingUI UI")]
    public GameObject _winScreen;
    public GameObject _CraftUI;

    [Header("Player Scripts")]
    public PlayerInventory inventory;
    public PlayerBehaviour playerBehaviour;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "_craftingBench")
        {
            Debug.Log("Entered crafting zone");
            playerBehaviour.menuIsOpen = true;
            CraftingUI.SetActive(true);
            PauseTime();
        }
    }




    public void CraftGrillCheese()
    {
        inventory._cheese -= 1;
        inventory._bread -= 1;
        inventory._butter -= 1;
        inventory.CraftGrilledCheese();
        Debug.Log("You have : " + inventory._grilledCheese + " Grilled Cheese Sandwiches");

    } 
    // Update is called once per frame
    void Update()
    {

        if (inventory._cheese <= 0 && inventory._bread <= 0 && inventory._butter <= 0)
        {
            //Debug.Log("You cant make it");
            CraftButtonOff.SetActive(false);
            hasAmount = false;
        }
        if (inventory._cheese >= 1 && inventory._bread >= 1 && inventory._butter >= 1)
        {
                //Debug.Log("You can make it!");
                CraftButtonON.SetActive(true);
                hasAmount = true;
        }
        if (inventory._grilledCheese >= 1)
        {
            playerBehaviour.menuIsOpen = true;
            _winScreen.SetActive(true);
            _CraftUI.SetActive(false);

        }

    }

    public void ResumeFire()
    {

        StartCoroutine(ResumeFireWait());
    }
    IEnumerator ResumeFireWait()
    {
        yield return new WaitForSeconds (2);
        playerBehaviour.menuIsOpen = false;
    }

   public void ResumeTime()
    {

        Time.timeScale = 1f;
        PauseScreen.GameIsPaused = false;
    }

   public void PauseTime()
    {

        Time.timeScale = 0f;
        PauseScreen.GameIsPaused = true;
    }
}

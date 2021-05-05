using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTrigger : MonoBehaviour
{
    public GameObject quest;
    public ItemManager itemManager;

    void OnTriggerEnter()
    {
        if(!(itemManager.gotToy && itemManager.gotNugget && itemManager.gotFries))
        {
            quest.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTrigger : MonoBehaviour
{
    public GameObject quest;

    void OnTriggerEnter()
    {
        quest.SetActive(true);
    }
}

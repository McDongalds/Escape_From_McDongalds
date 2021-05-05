using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public bool questDone = false;
    public bool gotFries;
    public bool gotNugget;
    public bool gotToy;
    public CharacterController playerController;
    public GameObject bigKid;
    public GameObject toyText;
    public GameObject friesText;
    public GameObject nuggetText;
    public GameObject congratsText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fries")
        {
            gotFries = true;
            Destroy(other.gameObject);
            friesText.SetActive(true);
            StartCoroutine(ClearText(friesText));
        }
        if (other.gameObject.tag == "Toy")
        {
            gotToy = true;
            Destroy(other.gameObject);
            toyText.SetActive(true);
            StartCoroutine(ClearText(toyText));
        }
        if (other.gameObject.tag == "Nuggets")
        {
            gotNugget = true;
            Destroy(other.gameObject);
            nuggetText.SetActive(true);
            StartCoroutine(ClearText(nuggetText));
        }  
    }

    void CheckItems()
    {
        if(gotFries && gotNugget && gotToy)
        {
            congratsText.SetActive(true);
            StartCoroutine(ClearText(congratsText));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gotFries && gotNugget && gotToy)
        {
            bigKid.transform.Translate(new Vector3(0f, -30f, 0f));
        }
    }

    private IEnumerator ClearText(GameObject text)
    {
        yield return new WaitForSeconds(3f);
        text.SetActive(false);
        if(text!=congratsText)
        {
            CheckItems();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public bool questDone = false;
    public bool gotFries;
    public bool gotNugget;
    public bool gotToy;
    public CharacterController playerController;
    public GameObject bigKid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Fries")
        {
            gotFries = true;
            other.transform.Translate(0f, -50f, 0f);
        }
        if (other.gameObject.tag == "Toy")
        {
            gotToy = true;
            other.transform.Translate(0f, 0f, -100f);

        }
        if (other.gameObject.tag == "Nuggets")
        {
            gotNugget = true;
            other.transform.Translate(0f, -10f, 0f);
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
}

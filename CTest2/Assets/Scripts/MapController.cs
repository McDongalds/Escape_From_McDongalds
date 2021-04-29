using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    public GameObject MapObject;
    // Start is called before the first frame update
    void Start()
    {
        MapObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("m")){
            MapObject.SetActive(true);
        }
        else{
            MapObject.SetActive(false);
        }
        //gameObject.SetActive(true);
    }
}

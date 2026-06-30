using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGuns : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Gun has been switched");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "InteractRIFLE")
        {
            Debug.Log("RifleYay");
        }
        if (collision.gameObject.tag == "InteractSHOTGUN")
        {
            Debug.Log("ShottyYay");
        }

    }
}

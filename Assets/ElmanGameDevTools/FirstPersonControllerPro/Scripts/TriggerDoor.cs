using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    private Animator _doorAnimator; // Reference to the Animator component on the door

    void Start()
    {
        _doorAnimator = GetComponent<Animator>();
        Debug.Log("Check");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
            // Trigger door to open
            Debug.Log("Open");
            _doorAnimator.SetTrigger("Open");
        }
    }


    /*private void OnTriggerExit(Collider other)
    {
        // Automatically close the door when the player leaves the trigger area
        if (other.CompareTag("Player"))
        {
            Debug.Log("Close");
            _doorAnimator.SetTrigger("Closed");
        }
    }*/
}

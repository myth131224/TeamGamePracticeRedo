using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
 
public class RifleProto : MonoBehaviour
{
    public GameObject bulletPrefab;
    GameObject bulletSpawnPoint;
    public bool coolDown; //establishes the cooldown idea

    void Start()
    {
        bulletSpawnPoint = transform.GetChild(0).gameObject;
        coolDown = false; //gun has not been shot yet
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && coolDown == false) //if the button is pressed AND the gun hasn't been shot
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
            //StartCoroutine(Cooldown()); //now that gun has been shot, it activates the cooldown
        }
    }
    IEnumerator Cooldown()
    {
        coolDown = true; //gun has been shot
        Debug.Log("Cooldown active");
        yield return null;
        yield return new WaitForSeconds(1f); //wait for one second (change 1f to make time different)
        coolDown = false; //cooldown has ended
        Debug.Log("Cooldown over");
    }

}
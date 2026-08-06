using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSwitch : MonoBehaviour
{
    public int selectedWeapon = 0; //Weapons will be child objects of player, making Weapon 1 "index 0"

    // Use this for initialization
    void Start()
    {
        SelectWeapon(); //calls the method to allow us to select the weapons
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon;

        //FOR SCROLLING
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // if greater than zero, scrolled up, if less than, scrolled down
        {
            if (selectedWeapon >= transform.childCount - 1) //checks the current amount of weapons we have
                selectedWeapon = 0; //if you have scrolled past the highest number, it is reset to index 0
            else
                selectedWeapon++; //to select next weapon in the chain
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectedWeapon <= 0)
                selectedWeapon = transform.childCount - 1;
            else
                selectedWeapon--;
        }

        //FOR USING NUMBER KEYS

        if (Input.GetKeyDown(KeyCode.Alpha1)) //press the 1 key
        {
            selectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2) //if you press the 2 key AND have two weapons
        {
            selectedWeapon = 1;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform) //take all the child objects of the child holder (player), will loop through each one, reffering to the current one we are inspecting as "weapon"
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true); //i.e if the selected weapon is 0, it will be active
            else
                weapon.gameObject.SetActive(false); //i.e if the selected weapon is 1, it will be inactive/disabled
            i++; //the first time you loop through, one will be added onto it -- so the second time it will == 1
        }
    }
}

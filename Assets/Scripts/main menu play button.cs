using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class mainmenuplaybutton : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1(ELYSE)");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float PlayerHp = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHp >= 0)
        {

        }
    }
   
    public void PlayerDamge()
    {
        new WaitForSeconds(100f);
        PlayerHp--;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float PlayerHp;
    public float MaxPlayerHP = 100f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHp = MaxPlayerHP;
    }
   
    public void PlayerDamge(float amount)
    {
        PlayerHp -= amount;
        if(PlayerHp <= 0)
        {
            Time.timeScale = 0f;
        }
    }
}

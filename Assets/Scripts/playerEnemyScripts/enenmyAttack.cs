using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enenmyAttack : MonoBehaviour
{
    public playerHealth PlayerHealth;
    public float damage = 10f;


    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            PlayerHealth.PlayerDamge(10f);
        }
    }

}

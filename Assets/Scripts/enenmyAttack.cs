using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enenmyAttack : MonoBehaviour
{
    public playerHealth playerHealth;
    public float damage = 10;

    /*private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            playerHealth.PlayerDamge(damage);
        }
    }
    */
}
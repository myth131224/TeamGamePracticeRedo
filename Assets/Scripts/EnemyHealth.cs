using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float EnemyHp;
    public float MaxEnemyHP = 100f;

    // Start is called before the first frame update
    void Start()
    {
        EnemyHp = MaxEnemyHP;
    }

    public void Update()
    {
        if (EnemyHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float amount)
    {
        EnemyHp -= amount;
    }
}

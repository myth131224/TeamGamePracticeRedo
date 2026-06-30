using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 25.0f;
    public float lifeTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
        Invoke("DestroySelf", 5.0f);
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

        DestroySelf();
    }
    
    void DestroySelf()
    {
        Destroy(gameObject);
    }
   /* void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();

        if (enemy != null)
            enemy.TakeDamage(damage);

        Destroy(gameObject);
    }
}*/
}
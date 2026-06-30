using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    public int maxAmmo = 10;
    public float fireRate = 1f;

    private int currentAmmo;
    private float nextShotTime;

    [SerializeField] int pelletCount = 8;
    [SerializeField] float spreadAngle = 5f;

    void Start()
    {
        currentAmmo = maxAmmo;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextShotTime && currentAmmo > 0)
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }

    void Shoot()
    {
        currentAmmo--;

        for (int i = 0; i < pelletCount; i++)
        {
            float xSpread = Random.Range(-spreadAngle, spreadAngle);
            float ySpread = Random.Range(-spreadAngle, spreadAngle);

            Quaternion spreadRotation =
                bulletSpawnPoint.rotation * Quaternion.Euler(ySpread, xSpread, 0);

            Instantiate(
                bulletPrefab,
                bulletSpawnPoint.position,
                spreadRotation);
        }

        nextShotTime = Time.time + fireRate;
    }

    void Reload()
    {
        currentAmmo = maxAmmo;
    }
}
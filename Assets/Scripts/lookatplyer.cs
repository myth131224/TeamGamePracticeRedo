using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class lookatplyer : MonoBehaviour
{
    public Transform target;
    public GameObject playerTargetInfo;

    private void Awake()
    {
        playerTargetInfo = GameObject.FindGameObjectWithTag("Player");

        target = playerTargetInfo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target);
        }
    }
}

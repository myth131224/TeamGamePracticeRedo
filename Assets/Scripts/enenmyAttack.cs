using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class enenmyAttack : MonoBehaviour
{
    playerHealth Health;
    public Transform Player;
    public GameObject playerTargetInfo;


    // Start is called before the first frame update
    private void Start()
    {
        Health = Player.GetComponent<playerHealth>();
    }

    private void Awake()
    {

        playerTargetInfo = GameObject.FindGameObjectWithTag("Player");

        Player = playerTargetInfo.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerStay(Collider Player)
    {
        Health.PlayerDamge();
    }

}

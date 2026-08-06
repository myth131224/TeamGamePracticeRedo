using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{

    public Transform target;
    NavMeshAgent agent;

    public GameObject playerTargetInfo;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Awake()
    {
        

        playerTargetInfo = GameObject.FindGameObjectWithTag("Player");

        target = playerTargetInfo.transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}

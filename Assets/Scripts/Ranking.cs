using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    public int SRankRequirement;
    public int ARankRequirement;
    public int BRankRequirement;
    public int CRankRequirement;
    public Timer timer;
    public string ranking;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer.currentTime < SRankRequirement)
        {
            ranking = "S";
        }

        if (timer.currentTime < ARankRequirement && timer.currentTime > SRankRequirement)
        {
            ranking = "A";
        }

        if (timer.currentTime < BRankRequirement && timer.currentTime > ARankRequirement)
        {
            ranking = "B";
        }

        if (timer.currentTime < CRankRequirement && timer.currentTime > BRankRequirement)
        {
            ranking = "C";
        }

        if (timer.currentTime > CRankRequirement)
        {
            ranking = "D";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
    }
}

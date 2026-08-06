using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public EndingTrigger ending;
    public Ranking ranking;
    public string finalRank;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (ending.isDone == true)
        {
            finalRank = ranking.ranking;
            GetComponent<TextMeshProUGUI>().text = finalRank;
            GetComponent<TextMeshProUGUI>().enabled = true;
            Time.timeScale = 0;
        }
    }

     private void OnTriggerEnter(Collider other)
    {

    }
    

}

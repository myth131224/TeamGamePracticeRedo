

using TMPro;

using UnityEngine;

public class TimerDisplay : MonoBehaviour

{

    public TextMeshProUGUI textMeshPro;

    public float time;

    public string numbers;

    // Update is called once per frame

    void Update()

    {

        time += Time.deltaTime;

        textMeshPro.text = time.ToString("00.00");

    }

}


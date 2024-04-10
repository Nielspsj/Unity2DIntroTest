using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI timerText;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timerText.text = timer.ToString("N0");
    }

    // Update is called once per frame
    void Update()
    {
        //Add a number every second to the timer.
        timer += Time.deltaTime;
        //Only add whole numbers to the timer shown to the player, no decimals.
        timerText.text = timer.ToString("N0");
    }
}

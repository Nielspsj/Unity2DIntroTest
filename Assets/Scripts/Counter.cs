using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    private int collectables = 0;

    private TextMeshProUGUI counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TextMeshProUGUI>();
        counterText.text = collectables.ToString();
    }

    public void UpdateCounter()
    {
        collectables++;
        counterText.text = collectables.ToString();
    }
}

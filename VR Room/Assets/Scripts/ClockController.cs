using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClockController : MonoBehaviour
{

    public TextMeshProUGUI clockText; // Drag your clock text here

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        clockText.text = currentTime.ToString("HH:mm:ss");
    }
}

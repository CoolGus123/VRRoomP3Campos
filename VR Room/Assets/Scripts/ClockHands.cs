using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHands : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        DateTime time = DateTime.Now;

        float seconds = time.Second;
        float minutes = time.Minute + seconds / 60f;
        float hours = time.Hour + minutes / 60f;

        secondHand.localRotation = Quaternion.Euler(0, -seconds * 6f, 0);
        minuteHand.localRotation = Quaternion.Euler(0, -minutes * 6f, 0);
        hourHand.localRotation = Quaternion.Euler(0, -hours * 30f, 0);
    }
}

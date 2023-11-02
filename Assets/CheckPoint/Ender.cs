using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ender : MonoBehaviour
{
    Timer timer;

    public bool countdownTimerStop;
    public float currentTime;

    // This is called when the player touches the start checkpoint.
    void OnTriggerEnter2D(Collider2D StartCheckpoint)
    {
        currentTime = 60f;
        // This allows the timer to stop.
        countdownTimerStop = true;
    }
}

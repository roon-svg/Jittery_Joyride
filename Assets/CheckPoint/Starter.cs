using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    Timer timer;

    public bool countdownTimerStart;
    public float currentTime;

    // This is called when the player touches the start checkpoint.
    void OnTriggerEnter2D(Collider2D StartCheckpoint)
    {
        // this makes sure that the timer is 60 seconds and no longer
        currentTime = 60f;
        // This allows for the timer to start
        countdownTimerStart = true;
    }
}

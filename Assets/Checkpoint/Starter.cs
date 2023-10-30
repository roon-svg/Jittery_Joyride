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
        currentTime = 60f;
        countdownTimerStart = true;
    }
}

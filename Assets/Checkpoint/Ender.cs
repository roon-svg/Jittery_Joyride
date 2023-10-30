using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Ender : MonoBehaviour
{
    Timer timer;
    public bool countdownTimerStop;


    void OnTriggerEnter2D(Collider2D EndCheckpoint)
    {
        countdownTimerStop = true;
    }
}

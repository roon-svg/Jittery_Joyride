using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ender : MonoBehaviour
{
    Timer timer;
    // Start is called before the first frame update
    public bool countdownTimerStart;
    public float currentTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider StartCheckpoint)
    {
        countdownTimerStart = false;
        if (StartCheckpoint.CompareTag("Player"))
        {
            currentTime = 30f;
        }
    }
}

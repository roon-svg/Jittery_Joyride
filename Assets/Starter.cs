using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
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
    void OnTriggerEnter2D(Collider2D StartCheckpoint)
    {
        countdownTimerStart = true;
        currentTime = 30f;
        if (StartCheckpoint.CompareTag("Player"))
        {
            currentTime = 30f;
        }
    }
}

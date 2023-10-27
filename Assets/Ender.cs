using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ender : MonoBehaviour
{
    Timer timer;
    // Start is called before the first frame update
    // public bool countdownTimerStart;
    public float currentTime;
    private int n = 0;

    Starter starter;
    [SerializeField] GameObject StartCheckpoint;
    void Start()
    {
        starter = StartCheckpoint.GetComponent<Starter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D EndCheckpoint)
    {
        starter.countdownTimerStart = false;
        //starter.touch += 1;
        Debug.Log("Timer Paused");
        /*
        if (starter.touch == 2*n+2)
        {
            countdownTimerStart = false;
        }
        */
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    public class StopWatch
    {
        public void StartCheck(float time)
        {
            void OnTriggerEnter(Collider StartCheckpoint)
            {
                bool countdownTimerStart = true;
                if (StartCheckpoint.CompareTag("Player"))
                {
                    // StartStopwatch(float currentTime, bool countdownTimerStart)
                }
            }
        }
        public void EndCheck(float time)
        {
            void OnTriggerEnter(Collider EndCheckpoint)
            {
                bool countdownTimerStart = false;
                if (EndCheckpoint.CompareTag("Player"))
                {
                    // StartStopwatch(float currentTime, bool countdownTimerStart)
                }
            }
        }
    }
}

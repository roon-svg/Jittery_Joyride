
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    Starter starter;
    [SerializeField] GameObject StartCheckpoint;
    Ender ender;
    [SerializeField] GameObject EndCheckpoint;

    public TextMeshProUGUI countdownText;
    Starter startCountdown;
    Ender endCountdown;
    // public float currentTime = 0f;

    // Start is called before the first frame update
    void Awake()
    {
        starter = StartCheckpoint.GetComponent<Starter>();
        ender = EndCheckpoint.GetComponent<Ender>();
    }

    // Update is called once per frame
    // This allows the countdown timer to work.

    void Update()
    {
        if (starter.countdownTimerStart == true)
        {
            starter.currentTime -= Time.deltaTime;
            countdownText.text = starter.currentTime.ToString();
        }
        else if (ender.countdownTimerStart == false)
        {
            StartTimer();
        }
        else if (starter.currentTime < 0)
        {

        }
    }

    void StartTimer()
    {
        starter.countdownTimerStart = false;
        Debug.Log("StartTimer function works");
        return;
    }

    public void UpdateTimer()
    {
        float CountdownTimer = starter.currentTime -= Time.deltaTime;
        countdownText.text = CountdownTimer.ToString();
    }

}

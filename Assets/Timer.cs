using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    #region variables
    Starter starter;
    [SerializeField] GameObject StartCheckpoint;
    Ender ender;
    [SerializeField] GameObject EndCheckpoint;

    public TextMeshProUGUI countdownText;
    #endregion

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
            UpdateTimer();
        }
        if (ender.countdownTimerStop == true)
        {
            starter.countdownTimerStart = false;

        }
        if (starter.currentTime < 0)
        {
            // SceneManager.LoadScene("GameOver");
        }
    }

    public void UpdateTimer()
    {
        float CountdownTimer = starter.currentTime -= Time.deltaTime;
        countdownText.text = CountdownTimer.ToString();
    }
}

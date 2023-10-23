
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;

    public float currentTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // This allows the countdown timer to work.
    void Update()
    {
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString();

        if (currentTime == 0)
        {
            //OnApplicationQuit();
        }
    }
}

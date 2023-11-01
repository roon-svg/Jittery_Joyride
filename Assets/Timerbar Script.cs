using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class TimerbarScript : MonoBehaviour
{
    public float checkpointTime = 60.0f; 
    // this is the total available time. The black circle in the game.

    private float currentTime;
    // This will represent the current time in the game. The red cirlce in the game is current time.

    public Image Timerfiller;
    // This will fill the timer bar in the game. The red circle will fill the black circle.

    void Start()
    {
        currentTime =  checkpointTime;
    }

    // This will make the timer start from 60 seconds. Current time will be 60.


    void Update()
    {
        if (currentTime > 0)
        // if statement added, if current time is more than 0, the code will do the following task below:
        {
            currentTime -= Time.deltaTime;
            // this will keep removing delta time in each frame from the total current time.

            Timerfiller.fillAmount = currentTime / checkpointTime;
            // Timer bar will be filled as the checkpointTime which is the total time passes.
        }

        else
        {currentTime = 0;

        }
        
    }
}

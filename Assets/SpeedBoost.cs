using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public bool boostOn;

    void OnTriggerEnter2D(Collider2D SpeedBoost)
    {
        boostOn = true;
    }
}

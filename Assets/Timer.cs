using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float cTime = 0f;
    public float startingTime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        cTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        cTime -= 1 * Time.deltaTime;
        cTime.Text
    }
}

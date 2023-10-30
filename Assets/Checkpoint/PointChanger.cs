using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointChanger : MonoBehaviour
{
    public GameObject StartCheckpoint;
    public GameObject EndCheckpoint;

    // Start is called before the first frame update
    public void spawner()
    {
        //Instantiate(StartCheckpoint, Vector2(x,y,0);
        Instantiate(EndCheckpoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

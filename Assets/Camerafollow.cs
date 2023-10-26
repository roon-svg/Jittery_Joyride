using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    private UnityEngine.Vector3 offsetCamera = new UnityEngine.Vector3(0f, 0f, -10f);
    // This defines offset of the cameram to the player.
    
    private float cameraSpeed = 0.25F;
    // This is the amount of time the camera will take to follow the car in the game. 
    // Using smooth time will enable the camera to follow the car smoothly.

    private UnityEngine.Vector3 velocity = UnityEngine.Vector3.zero;
    // This is for the velocity of the car in the game.

    [SerializeField] private Transform targetcar;
    //This is the target which the camera will follow once all game files are added in unity editor.


    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector3 targetPosition = targetcar.position + offsetCamera;
        // This will help the camera to keep up with the car at the start position.

        transform.position = UnityEngine.Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, cameraSpeed);
        // This will help to change camera position at new positions over time as the car moves.


    }

}


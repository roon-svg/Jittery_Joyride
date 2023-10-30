using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region variables
    public float Speed = 5f;
    public float input1;
    
    public float TurningSpeed = 500;
    #endregion

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        GameObject.DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        #region player movement
        // This allows for the side ways input to be stored
        float horizontalInput = Input.GetAxis("Horizontal");
        // This allows for the vertical input to be stored.
        float verticalInput = Input.GetAxis("Vertical");

        // This allows the player to go diagonally if there are 2 keys pressed at once.
        Vector2 Direction = new Vector2(horizontalInput, verticalInput);
        float Magnitude = Mathf.Clamp01(Direction.magnitude);
        Direction.Normalize();

        // This code makes the player move.
        transform.Translate(Direction * Speed * Magnitude * Time.deltaTime, Space.World);
        #endregion

        #region player rotation
        //This allows the player to rotate
        if (Direction != Vector2.zero)
        {
            Quaternion Rotation = Quaternion.LookRotation(transform.forward, Direction);
            Quaternion MoveRotation = transform.rotation = Quaternion.RotateTowards(transform.rotation, Rotation, TurningSpeed * Time.deltaTime);

            rb.MoveRotation(MoveRotation);
        }
        #endregion
    }


}

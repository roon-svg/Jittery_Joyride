using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringPlayer : MonoBehaviour
{
    // This allows us to change the acceleration of the car
    public float acceleration = 5;
    public float maxSpeed = 100;
    public float Turn = 3;
    public float drift = .75f;
    Rigidbody2D rb;
    float accelerationInput;
    float steeringInput;
    float rotationAngle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accelerationInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
    }
    void FixedUpdate()
    {
        ApplyEngineForce();
        KillLateralVelocity();
        ApplySteering();
    }
    void ApplyEngineForce()
    {
        // This stops the car
        if (accelerationInput == 0)
        {
            rb.drag = Mathf.Lerp(rb.drag, 2, Time.fixedDeltaTime * 3);
        }
        else
        {
            rb.drag = 0.1f;
        }

        // This calculates how fast we are going
        float forwardVelocity = UnityEngine.Vector2.Dot(transform.up, rb.velocity);

        // Making a max speed
        if (forwardVelocity > maxSpeed && accelerationInput == 1)
        {
            return;
        }
        //Force for engine
        // UnityEngine.Vector2 engineForceVector = transform.up * acceleration * accelerationInput;

        // rb.AddForce(engineForceVector, ForceMode2D.Force);
    }
    void ApplySteering()
    {
        // This updates the rotation angle based on the input
        rotationAngle -= steeringInput * Turn;

        // This rotated the car.
        rb.MoveRotation(rotationAngle);
    }

    // This allows the car to top and accelerate.
    void KillLateralVelocity()
    {
        UnityEngine.Vector2 forwardVelocity = transform.up * UnityEngine.Vector2.Dot(rb.velocity, transform.up);
        UnityEngine.Vector2 lateralVelocity = transform.right * UnityEngine.Vector2.Dot(rb.velocity, transform.right);
        rb.velocity = forwardVelocity * lateralVelocity * drift;
    }
}

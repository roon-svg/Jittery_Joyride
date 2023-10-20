using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    public float input1;
    public float TurningSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 Direction = new Vector2(horizontalInput, verticalInput);
        float Magnitude = Mathf.Clamp01(Direction.magnitude);
        Direction.Normalize();

        transform.Translate(Direction * Speed * Magnitude * Time.deltaTime, Space.World);
    }

}

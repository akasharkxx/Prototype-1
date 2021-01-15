using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveSpeed, turnSpeed;
    private float horizontalInput, forwardInput;

    private void Start()
    {
        moveSpeed = 15.0f;
        turnSpeed = 25.0f;
    }

    private void Update()
    {
        //Get Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);
        //Steer vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

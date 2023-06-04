using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationSpeedRange = new Vector3(30f, 60f, 45f); // Minimum and maximum speed of rotation in degrees per second for each axis
    public Vector3 rotationRange = new Vector3(45f, 45f, 45f); // Maximum rotation range in degrees for each axis

    private Quaternion initialRotation; // Initial rotation of the spotlight
    private Vector3 rotationSpeed; // Speed of rotation in degrees per second for each axis
    private Vector3 targetRotation; // Target rotation for each axis

    private void Start()
    {
        // Store the initial rotation of the spotlight
        initialRotation = transform.rotation;

        // Set random rotation speed for each axis within the specified range
        rotationSpeed = new Vector3(Random.Range(rotationSpeedRange.x, rotationSpeedRange.y),
                                    Random.Range(rotationSpeedRange.x, rotationSpeedRange.y),
                                    Random.Range(rotationSpeedRange.x, rotationSpeedRange.y));

        // Set random target rotation for each axis within the specified range
        targetRotation = new Vector3(Random.Range(-rotationRange.x, rotationRange.x),
                                     Random.Range(-rotationRange.y, rotationRange.y),
                                     Random.Range(-rotationRange.z, rotationRange.z));
    }

    private void Update()
    {
        // Calculate the rotation amount based on the rotation speed and time
        Vector3 rotationAmount = rotationSpeed * Time.deltaTime;

        // Rotate the spotlight towards the target rotation for each axis
        transform.rotation *= Quaternion.Euler(rotationAmount);

        // Check if the target rotation is reached for each axis
        if (Quaternion.Angle(transform.rotation, initialRotation * Quaternion.Euler(targetRotation)) <= 0.1f)
        {
            // Set random target rotation for each axis within the specified range
            targetRotation = new Vector3(Random.Range(-rotationRange.x, rotationRange.x),
                                         Random.Range(-rotationRange.y, rotationRange.y),
                                         Random.Range(-rotationRange.z, rotationRange.z));
        }
    }
}

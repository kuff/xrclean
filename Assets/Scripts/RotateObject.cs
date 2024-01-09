using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 50.0f;  // Base rotation speed
    public float frequency = 1.0f;       // Frequency of the sine wave

    protected void Update()
    {
        // Calculate rotation for each axis
        var xRotation = Mathf.Sin(Time.time * frequency) * rotationSpeed * Time.deltaTime;
        var yRotation = Mathf.Sin(Time.time * frequency + Mathf.PI / 2) * rotationSpeed * Time.deltaTime;  // Phase shift for variance
        var zRotation = Mathf.Sin(Time.time * frequency + Mathf.PI) * rotationSpeed * Time.deltaTime;      // Another phase shift

        // Apply the rotation
        transform.Rotate(xRotation, yRotation, zRotation, Space.Self);
    }
}

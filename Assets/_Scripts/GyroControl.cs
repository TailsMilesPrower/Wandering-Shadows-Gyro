using UnityEngine;

public class GyroControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rotation;

    private void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        
        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rotation = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }

    private void Update()
    {
        if (gyroEnabled)
        {
            transform.localRotation = gyro.attitude * rotation;
        }
    }

}

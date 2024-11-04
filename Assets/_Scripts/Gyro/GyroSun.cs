using UnityEngine;

public class GyroSun : MonoBehaviour
{
    public GameObject objectToRotateSun;
    Quaternion targetRotation;


    private void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
        }
        
        targetRotation = Quaternion.Euler(45, 0, 0);
    }

    private void FixedUpdate()
    {
        if (SystemInfo.supportsGyroscope)
        {
            CheckRotation();
        }
    }

    void CheckRotation()
    {
        float yRotation = objectToRotateSun.transform.eulerAngles.y + Input.gyro.rotationRateUnbiased.y;
        targetRotation = Quaternion.Euler(45, yRotation, 0);

        /*
        if (Input.GetKey(KeyCode.Q))
        {
            targetRotation = Quaternion.Euler(45, objectToRotateSun.transform.eulerAngles.y - 1f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            targetRotation = Quaternion.Euler(45, objectToRotateSun.transform.eulerAngles.y + 1f, 0);
        }
        */

        objectToRotateSun.transform.rotation = targetRotation;
    }
}

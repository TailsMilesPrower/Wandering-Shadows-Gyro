using UnityEngine;

public class GyroControl : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;

    //private GameObject cameraContainer;
    private GameObject Camera_FollowsPlayer_Prefab;
    public Camera cam;

    private Quaternion rotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        GameObject gameObject = Instantiate(Camera_FollowsPlayer_Prefab);
        Camera_FollowsPlayer_Prefab.transform.position = transform.position;
        transform.SetParent(Camera_FollowsPlayer_Prefab.transform);

        //cameraContainer = new GameObject("Camera Container");
        //cameraContainer.transform.position = transform.position;
        //transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            
            Camera_FollowsPlayer_Prefab.transform.rotation = Quaternion.Euler(60f, 180f, 0f);
            //cameraContainer.transform.rotation = Quaternion.Euler(60f, 180f, 0f);
            rotation = new Quaternion(0, 0, 1, 0);

            return true;
        }

        return false;
    }

    private void Update()
    {
        if (gyroEnabled)
        {
            Quaternion gyroAttitude = gyro.attitude * rotation;
            Vector3 euler = gyroAttitude.eulerAngles;
            float yRotation = euler.y;

            transform.localRotation = gyro.attitude * rotation;
        }
    }

}

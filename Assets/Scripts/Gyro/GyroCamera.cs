using UnityEngine;

public class GyroCamera : MonoBehaviour
{
    private bool gyroEnabled;
    private Quaternion rotation;


    void FixedUpdate()
    {
        if (gyroEnabled)
        {
            transform.Rotate(0, 0, -1, 0);
        }
        
        if (gyroEnabled)
        {
            transform.Rotate(0, 0, 1, 0);
            //rotation = new Quaternion(0, 0, 1, 0);
        }
    }
}

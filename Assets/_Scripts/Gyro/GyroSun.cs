using UnityEngine;

public class GyroSun : MonoBehaviour
{
    public GameObject objectToRotateSun;
    //public GameObject objectToRotateCamera;
    //public Transform player;
    Quaternion targetRotation;
    //Quaternion targetRotationCam;

    private void Start()
    {
        targetRotation = Quaternion.Euler(45, 0, 0);
        //targetRotationCam = Quaternion.LookRotation(player.position - objectToRotateCamera.transform.position, Vector3.up);
    }

    private void FixedUpdate()
    {
        CheckRotation();
    }

    // Update is called once per frame
    void CheckRotation()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            targetRotation = Quaternion.Euler(45, objectToRotateSun.transform.eulerAngles.y - 1f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            targetRotation = Quaternion.Euler(45, objectToRotateSun.transform.eulerAngles.y + 1f, 0);
        }
        objectToRotateSun.transform.rotation = targetRotation;

        /*if (Input.GetKey(KeyCode.Q))
        {
            targetRotationCam = Quaternion.Euler(0, objectToRotateCamera.transform.eulerAngles.y - 1f, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            targetRotationCam = Quaternion.Euler(0, objectToRotateCamera.transform.eulerAngles.y + 1f, 0);
        }
        objectToRotateCamera.transform.rotation = targetRotationCam;*/


    }
}

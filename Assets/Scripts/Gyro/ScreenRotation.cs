using UnityEngine;

public class ScreenRotation : MonoBehaviour
{
    public static ScreenRotation orientation;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Screen.orientation = ScreenOrientation.LandscapeLeft;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }
}

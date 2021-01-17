using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject ObjectToLookAt;
    Camera temp_camera;
    [SerializeField] RampComtroller rampComtroller;

    void Start()
    {
        temp_camera = gameObject.GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        if (temp_camera.enabled){
            gameObject.transform.LookAt(rampComtroller.GetCurrentModel().transform);
        }
    }
}

using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]GameObject Ramp;
    Camera temp_camera;
    [SerializeField] RampComtroller rampComtroller;
    [SerializeField] bool FollowPlayer, LookAtPlayer;
    [Tooltip("Offset for the camera to determine from how far the user have to follow")]
    [SerializeField] Vector3 offset;

    Vector3 desiredPosition;

    void Start()
    {
        temp_camera = gameObject.GetComponent<Camera>();
        desiredPosition = new Vector3();
    }

    void Update()
    {
        if (temp_camera.enabled){
            if (FollowPlayer){
                gameObject.transform.position = rampComtroller.GetCurrentModel().transform.position+offset;
                // gameObject.transform.position -= Ramp.transform.position;
            }
            if (LookAtPlayer){
                gameObject.transform.LookAt(rampComtroller.GetCurrentModel().transform);
            }
                
        }
    }
}

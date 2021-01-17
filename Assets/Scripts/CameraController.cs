using System;
using UnityEngine;

[Serializable] struct CameraSet{
    [SerializeField] public Camera PrevCamera;
    [SerializeField] public Camera NextCamera;
};

public class CameraController : MonoBehaviour
{
    [Tooltip("Choose the prev Camera and the camera you want to active")]
    [SerializeField]CameraSet cameraSet;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Model")
            return;
        
        if (cameraSet.PrevCamera)
            cameraSet.PrevCamera.enabled = false;
        if (cameraSet.NextCamera)
            cameraSet.NextCamera.enabled = true;

    }
}

using System;
using UnityEngine;

[Serializable] public struct CameraSet{
    [Serializable]public struct data{
        public Camera camera;
        public AudioListener audioListener;
    };

    [SerializeField] public data PrevCamera;
    [SerializeField] public data NextCamera;
    
};

public class CameraController : MonoBehaviour
{
    [Tooltip("Choose the prev Camera and the camera you want to active")]
    [SerializeField]CameraSet cameraSet;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Model")
            return;
        
        if (cameraSet.PrevCamera.camera.enabled){
            cameraSet.PrevCamera.camera.enabled = false;
            cameraSet.PrevCamera.audioListener.enabled = false;
        }
            
        if (!cameraSet.NextCamera.camera.enabled){
            cameraSet.NextCamera.camera.enabled = true;
            cameraSet.NextCamera.audioListener.enabled = true;
        }
            

    }
}

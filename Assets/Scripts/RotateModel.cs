using UnityEngine;

public class RotateModel : MonoBehaviour
{
    
    [SerializeField] Vector3 Rotateangle;
    [SerializeField] RampComtroller rampController;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Model")
            return;

        rampController.RotateModel(ref Rotateangle);
    }
}
